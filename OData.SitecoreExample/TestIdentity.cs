using Sitecore.Services.Core.Model;

namespace OData.SitecoreExample
{
    // add reference to Sitecore.Services.Core 
    public class TestIdentity :EntityIdentity
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}