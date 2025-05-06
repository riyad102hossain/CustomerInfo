using Microsoft.Extensions.Localization;
using Customerinfo.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Customerinfo;

[Dependency(ReplaceServices = true)]
public class CustomerinfoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CustomerinfoResource> _localizer;

    public CustomerinfoBrandingProvider(IStringLocalizer<CustomerinfoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
