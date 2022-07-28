using VendaCap.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace VendaCap.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class VendaCapPageModel : AbpPageModel
{
    protected VendaCapPageModel()
    {
        LocalizationResourceType = typeof(VendaCapResource);
    }
}
