using Northwind.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Northwind.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NorthwindController : AbpControllerBase
{
    protected NorthwindController()
    {
        LocalizationResource = typeof(NorthwindResource);
    }
}
