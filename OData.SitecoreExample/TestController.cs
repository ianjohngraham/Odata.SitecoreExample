using Sitecore.Services.Core.Data;
using Sitecore.Services.Infrastructure.OData;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace OData.SitecoreExample
{
    // add reference to Sitecore.Services.Core and Sitecore.Services.Infrastructure, System.Web.OData and System.Web.Http - they're in the Sitecore bin folder!
    public class TestController : ServiceBaseODataController<TestIdentity>
    {
        protected IReadOnlyEntityRepository<TestIdentity> TestRepository { get; private set; }


        public TestController(IReadOnlyEntityRepository<TestIdentity> repository)
             : base(repository)
        {
            TestRepository = new TestRepository();
        }

        public override async Task<IHttpActionResult> Get()
        {
            IQueryable<TestIdentity> result = await TestRepository.GetData();
            return Ok(result);
        }
    }
}