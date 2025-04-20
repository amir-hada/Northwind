using Volo.Abp.Modularity;

namespace Northwind;

/* Inherit from this class for your domain layer tests. */
public abstract class NorthwindDomainTestBase<TStartupModule> : NorthwindTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
