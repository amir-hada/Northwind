using Microsoft.Extensions.Localization;
using Northwind.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Northwind.Blazor.WebApp.Tiered;

[Dependency(ReplaceServices = true)]
public class NorthwindBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<NorthwindResource> _localizer;

    public NorthwindBrandingProvider(IStringLocalizer<NorthwindResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
