using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Squadra.Person.Data.Sdk
{
    public interface IPersonReadRepository
    {
        /// <summary>
        /// List all people from this fake data generator.
        /// </summary>
        /// <returns>An IEnumerable of Person.</returns>
        Task<IEnumerable<Person>> ListAsync();
        
        /// <summary>
        /// Page people from this fake data generator.
        /// </summary>
        /// <param name="number">Page number.</param>
        /// <param name="size">Page size.</param>
        /// <returns>An IEnumerable of paged Person.</returns>
        Task<IEnumerable<Person>> PageAsync(int number, int size);
        
        /// <summary>
        /// Get a person by Id.
        /// </summary>
        /// <param name="id">Person Id.</param>
        /// <returns>Person.</returns>
        Task<Person> GetAsync(Guid id);
    }
}