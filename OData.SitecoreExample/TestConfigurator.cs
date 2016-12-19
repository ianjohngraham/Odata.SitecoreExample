using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Services.Core.Data;
using Sitecore.Services.Infrastructure.Sitecore.DependencyInjection;

namespace OData.SitecoreExample
{
    // Add project reference to  Microsoft.Extensions.DependencyInjection, Microsoft.Extensions.DependencyInjection.Abstractions, Sitecore.Services.Core

    public class TestConfigurator : IServicesConfigurator
    {
        public  void Configure(IServiceCollection serviceCollection)
        {
            var assemblies = new[] {this.GetType().Assembly };
            serviceCollection.AddWebApiControllers(assemblies);
            serviceCollection.AddSingleton<IReadOnlyEntityRepository<TestIdentity>, TestRepository>();
        }
    }
}