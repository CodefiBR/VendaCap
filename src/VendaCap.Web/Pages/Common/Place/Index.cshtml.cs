using System.Threading.Tasks;

namespace VendaCap.Web.Pages.Common.Place;

public class IndexModel : VendaCapPageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}
