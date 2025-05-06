using Customerinfo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Customerinfo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CustomerinfoController : AbpControllerBase
{
    protected CustomerinfoController()
    {
        LocalizationResource = typeof(CustomerinfoResource);
    }
}
