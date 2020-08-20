using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Squadra.Person.Data.Sdk
{
    [ExcludeFromCodeCoverage]
    public static class PersonReadRepositoryExtensions
    {
        public static IServiceCollection AddFakePersonDataSdk(this IServiceCollection services)
        {
            return services.AddScoped<IPersonReadRepository, PersonReadRepository>();
        }
    }
}