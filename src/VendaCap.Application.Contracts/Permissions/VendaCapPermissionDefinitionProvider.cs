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

        var ticketSetPermission = myGroup.AddPermission(VendaCapPermissions.TicketSet.Default, L("Permission:TicketSet"));
        ticketSetPermission.AddChild(VendaCapPermissions.TicketSet.Create, L("Permission:Create"));
        ticketSetPermission.AddChild(VendaCapPermissions.TicketSet.Update, L("Permission:Update"));
        ticketSetPermission.AddChild(VendaCapPermissions.TicketSet.Delete, L("Permission:Delete"));

        var personPermission = myGroup.AddPermission(VendaCapPermissions.Person.Default, L("Permission:Person"));
        personPermission.AddChild(VendaCapPermissions.Person.Create, L("Permission:Create"));
        personPermission.AddChild(VendaCapPermissions.Person.Update, L("Permission:Update"));
        personPermission.AddChild(VendaCapPermissions.Person.Delete, L("Permission:Delete"));

        var placePermission = myGroup.AddPermission(VendaCapPermissions.Place.Default, L("Permission:Place"));
        placePermission.AddChild(VendaCapPermissions.Place.Create, L("Permission:Create"));
        placePermission.AddChild(VendaCapPermissions.Place.Update, L("Permission:Update"));
        placePermission.AddChild(VendaCapPermissions.Place.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<VendaCapResource>(name);
    }
}
