using Customerinfo.Samples;
using Xunit;

namespace Customerinfo.EntityFrameworkCore.Domains;

[Collection(CustomerinfoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CustomerinfoEntityFrameworkCoreTestModule>
{

}
