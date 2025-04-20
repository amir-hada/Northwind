using Volo.Abp.Modularity;

namespace Northwind;

[DependsOn(
    typeof(NorthwindApplicationModule),
    typeof(NorthwindDomainTestModule)
)]
public class NorthwindApplicationTestModule : AbpModule
{

}
