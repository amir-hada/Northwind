using Volo.Abp.Modularity;

namespace Northwind;

public abstract class NorthwindApplicationTestBase<TStartupModule> : NorthwindTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
