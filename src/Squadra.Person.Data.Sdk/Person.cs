using System;

namespace Squadra.Person.Data.Sdk
{
    public sealed class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Region { get; set; }
        public long Points { get; set; }
    }
}