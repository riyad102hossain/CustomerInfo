using Customerinfo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Customerinfo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerinfoEntityFrameworkCoreModule),
    typeof(CustomerinfoApplicationContractsModule)
    )]
public class CustomerinfoDbMigratorModule : AbpModule
{
}
