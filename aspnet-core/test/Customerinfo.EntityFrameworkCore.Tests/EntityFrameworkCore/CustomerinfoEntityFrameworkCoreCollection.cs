using Xunit;

namespace Customerinfo.EntityFrameworkCore;

[CollectionDefinition(CustomerinfoTestConsts.CollectionDefinitionName)]
public class CustomerinfoEntityFrameworkCoreCollection : ICollectionFixture<CustomerinfoEntityFrameworkCoreFixture>
{

}
