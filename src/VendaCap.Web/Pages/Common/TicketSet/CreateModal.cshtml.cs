using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendaCap.Common;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.TicketSet.ViewModels;

namespace VendaCap.Web.Pages.Common.TicketSet;

public class CreateModalModel : VendaCapPageModel
{
    [BindProperty]
    public CreateEditTicketSetViewModel ViewModel { get; set; }

    private readonly ITicketSetAppService _service;

    public CreateModalModel(ITicketSetAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditTicketSetViewModel, CreateUpdateTicketSetDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}