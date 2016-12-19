using Sitecore.Services.Core.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OData.SitecoreExample
{
    // add reference to Sitecore.Services.Core 
    public class TestRepository : IReadOnlyEntityRepository<TestIdentity>
    {
     
        public Task<TestIdentity> GetById(string id)
        {
            return Task.FromResult<TestIdentity>(new TestIdentity());
        }

        public Task<IQueryable<TestIdentity>> GetData()
        {
            var list = new List<TestIdentity>();
            var test  = new TestIdentity();
            test.Title = "Hello";
            test.Id = "1";

            list.Add(test);

            var test2 = new TestIdentity();
            test2.Title = "Hello 2";
            test2.Id = "2";

            list.Add(test2);

            var querable = list.AsQueryable();

            return Task.FromResult<IQueryable<TestIdentity>>(querable);
        }
    }
}