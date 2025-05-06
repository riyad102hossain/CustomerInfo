using Volo.Abp.Modularity;

namespace Customerinfo;

public abstract class CustomerinfoApplicationTestBase<TStartupModule> : CustomerinfoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
