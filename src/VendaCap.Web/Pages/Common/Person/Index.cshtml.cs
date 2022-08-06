using System.Threading.Tasks;

namespace VendaCap.Web.Pages.Common.Person;

public class IndexModel : VendaCapPageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}
