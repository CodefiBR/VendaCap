using System;
using System.Collections.Generic;
using System.Text;
using VendaCap.Localization;
using Volo.Abp.Application.Services;

namespace VendaCap;

/* Inherit your application services from this class.
 */
public abstract class VendaCapAppService : ApplicationService
{
    protected VendaCapAppService()
    {
        LocalizationResource = typeof(VendaCapResource);
    }
}
