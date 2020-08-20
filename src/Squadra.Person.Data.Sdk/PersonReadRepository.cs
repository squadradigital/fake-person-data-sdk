using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Squadra.Person.Data.Sdk.UnitTests")]

namespace Squadra.Person.Data.Sdk
{
    internal class PersonReadRepository : IPersonReadRepository
    {
        public Task<IEnumerable<Person>> ListAsync()
        {
            return Task.Run(ReadFile);
        }

        public Task<IEnumerable<Person>> PageAsync(int number, int size)
        {
            return Task.Run(() => ReadFile().Skip(size * (number - 1)).Take(size));
        }

        public Task<Person> GetAsync(Guid id)
        {
            return Task.Run(() => ReadFile().FirstOrDefault(p => p.Id == id));
        }

        private static IEnumerable<Person> ReadFile()
        {
            var filePath = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty,
                "data.txt"
            );

            var file = File.ReadAllLines(filePath);

            foreach (var line in file)
            {
                var data = line.Split(';');
                if (data.Length == 5)
                    yield return new Person()
                    {
                        Id = Guid.Parse(data[0]),
                        Name = data[1],
                        Birthdate = DateTime.Parse(data[2]),
                        Region = data[3],
                        Points = long.Parse(data[4])
                    };
            }
        }
    }
}