using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace VendaCap.Web;

[Dependency(ReplaceServices = true)]
public class VendaCapBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "VendaCap";
}
