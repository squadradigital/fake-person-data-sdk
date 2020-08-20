using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Squadra.Person.Data.Sdk.UnitTests
{
    public class PersonReadRepositoryUnitTests
    {
        [Fact]
        public async Task ShouldListAllPeople()
        {
            var repo = new PersonReadRepository();
            var result = await repo.ListAsync();
            
            result
                .Should()
                .HaveCount(1000);
        }

        [Fact]
        public async Task ShouldListPagedPeople()
        {
            var repo = new PersonReadRepository();
            var result = await repo.PageAsync(1, 50);
            
            result
                .Should()
                .HaveCount(50);
        }

        [Fact]
        public async Task ShouldGetPerson()
        {
            var repo = new PersonReadRepository();
            var result = await repo.GetAsync(Guid.Parse("B6331C97-3A4B-4A22-8843-3E25F851712A"));
            
            result
                .Should()
                .NotBeNull();

            result
                .Name
                .Should()
                .BeEquivalentTo("Agildo Rodrigues Silveira");

            result
                .Birthdate
                .Should()
                .Be(new DateTime(1997, 9, 3));

            result
                .Region
                .Should()
                .BeEquivalentTo("SP");

            result
                .Points
                .Should()
                .Be(342237227);
        }
    }
}