using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Customerinfo.Data;
using Volo.Abp.DependencyInjection;

namespace Customerinfo.EntityFrameworkCore;

public class EntityFrameworkCoreCustomerinfoDbSchemaMigrator
    : ICustomerinfoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCustomerinfoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CustomerinfoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CustomerinfoDbContext>()
            .Database
            .MigrateAsync();
    }
}
