using Volo.Abp.Settings;

namespace Customerinfo.Settings;

public class CustomerinfoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CustomerinfoSettings.MySetting1));
    }
}
