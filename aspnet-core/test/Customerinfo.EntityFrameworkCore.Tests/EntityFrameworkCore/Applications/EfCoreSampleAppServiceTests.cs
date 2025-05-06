using Customerinfo.Samples;
using Xunit;

namespace Customerinfo.EntityFrameworkCore.Applications;

[Collection(CustomerinfoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CustomerinfoEntityFrameworkCoreTestModule>
{

}
