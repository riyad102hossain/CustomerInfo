using Volo.Abp.Modularity;

namespace Customerinfo;

[DependsOn(
    typeof(CustomerinfoDomainModule),
    typeof(CustomerinfoTestBaseModule)
)]
public class CustomerinfoDomainTestModule : AbpModule
{

}
