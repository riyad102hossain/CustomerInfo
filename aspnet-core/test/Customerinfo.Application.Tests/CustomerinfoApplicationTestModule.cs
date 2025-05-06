using Volo.Abp.Modularity;

namespace Customerinfo;

[DependsOn(
    typeof(CustomerinfoApplicationModule),
    typeof(CustomerinfoDomainTestModule)
)]
public class CustomerinfoApplicationTestModule : AbpModule
{

}
