using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Customerinfo.Data;

/* This is used if database provider does't define
 * ICustomerinfoDbSchemaMigrator implementation.
 */
public class NullCustomerinfoDbSchemaMigrator : ICustomerinfoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
