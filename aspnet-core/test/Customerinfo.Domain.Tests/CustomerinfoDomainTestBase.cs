using Volo.Abp.Modularity;

namespace Customerinfo;

/* Inherit from this class for your domain layer tests. */
public abstract class CustomerinfoDomainTestBase<TStartupModule> : CustomerinfoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
