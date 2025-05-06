using System.Threading.Tasks;

namespace Customerinfo.Data;

public interface ICustomerinfoDbSchemaMigrator
{
    Task MigrateAsync();
}
