using Northwind.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Northwind.Permissions;

public class NorthwindPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NorthwindPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NorthwindPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NorthwindResource>(name);
    }
}
