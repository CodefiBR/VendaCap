using VendaCap.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VendaCap.Permissions;

public class VendaCapPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(VendaCapPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(VendaCapPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<VendaCapResource>(name);
    }
}
