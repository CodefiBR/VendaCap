using VendaCap.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VendaCap.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class VendaCapController : AbpControllerBase
{
    protected VendaCapController()
    {
        LocalizationResource = typeof(VendaCapResource);
    }
}
