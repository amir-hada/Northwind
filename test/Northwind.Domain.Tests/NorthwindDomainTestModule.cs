using Volo.Abp.Modularity;

namespace Northwind;

[DependsOn(
    typeof(NorthwindDomainModule),
    typeof(NorthwindTestBaseModule)
)]
public class NorthwindDomainTestModule : AbpModule
{

}
