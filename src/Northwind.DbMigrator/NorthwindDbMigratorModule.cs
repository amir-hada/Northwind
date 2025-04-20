using Northwind.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Northwind.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NorthwindEntityFrameworkCoreModule),
    typeof(NorthwindApplicationContractsModule)
    )]
public class NorthwindDbMigratorModule : AbpModule
{
}
