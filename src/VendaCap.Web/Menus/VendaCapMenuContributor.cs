using System.Threading.Tasks;
using VendaCap.Permissions;
using VendaCap.Localization;
using VendaCap.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace VendaCap.Web.Menus;

public class VendaCapMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<VendaCapResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                VendaCapMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
        if (await context.IsGrantedAsync(VendaCapPermissions.TicketSet.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(VendaCapMenus.TicketSet, l["Menu:TicketSet"], "/Common/TicketSet")
            );
        }
        if (await context.IsGrantedAsync(VendaCapPermissions.Person.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(VendaCapMenus.Person, l["Menu:Person"], "/Common/Person")
            );
        }
        if (await context.IsGrantedAsync(VendaCapPermissions.Place.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(VendaCapMenus.Place, l["Menu:Place"], "/Common/Place")
            );
        }
    }
}
