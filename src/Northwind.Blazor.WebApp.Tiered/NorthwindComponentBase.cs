using Northwind.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Northwind.Blazor.WebApp.Tiered;

public abstract class NorthwindComponentBase : AbpComponentBase
{
    protected NorthwindComponentBase()
    {
        LocalizationResource = typeof(NorthwindResource);
    }
}
