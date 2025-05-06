using System;
using System.Collections.Generic;
using System.Text;
using Customerinfo.Localization;
using Volo.Abp.Application.Services;

namespace Customerinfo;

/* Inherit your application services from this class.
 */
public abstract class CustomerinfoAppService : ApplicationService
{
    protected CustomerinfoAppService()
    {
        LocalizationResource = typeof(CustomerinfoResource);
    }
}
