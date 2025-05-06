using Customerinfo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Customerinfo.Permissions;

public class CustomerinfoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerinfoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CustomerinfoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerinfoResource>(name);
    }
}
