using Sitecore.Services.Core.OData;
using Sitecore.Services.Core.OData.Edm;
using Sitecore.Services.Infrastructure.OData.Edm;

namespace OData.SitecoreExample
{
    public class TestServiceDescriptor : AggregateDescriptor
    {
        public TestServiceDescriptor()
            : base(
                "custom", //route name
                "custom",  //route prefix
               new DefaultEdmModelBuilder(new[]
            {
                new EntitySetDefintion(typeof(TestIdentity), "Test")
               
            }))
        {
        }
    }

}