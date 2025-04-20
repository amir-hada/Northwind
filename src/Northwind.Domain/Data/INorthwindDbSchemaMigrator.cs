using System.Threading.Tasks;

namespace Northwind.Data;

public interface INorthwindDbSchemaMigrator
{
    Task MigrateAsync();
}
