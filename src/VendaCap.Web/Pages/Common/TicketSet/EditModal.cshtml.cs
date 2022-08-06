using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendaCap.Common;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.TicketSet.ViewModels;

namespace VendaCap.Web.Pages.Common.TicketSet;

public class EditModalModel : VendaCapPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditTicketSetViewModel ViewModel { get; set; }

    private readonly ITicketSetAppService _service;

    public EditModalModel(ITicketSetAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<TicketSetDto, CreateEditTicketSetViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditTicketSetViewModel, CreateUpdateTicketSetDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}