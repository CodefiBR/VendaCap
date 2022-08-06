using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendaCap.Common;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.Person.ViewModels;

namespace VendaCap.Web.Pages.Common.Person;

public class EditModalModel : VendaCapPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditPersonViewModel ViewModel { get; set; }

    private readonly IPersonAppService _service;

    public EditModalModel(IPersonAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<PersonDto, CreateEditPersonViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditPersonViewModel, CreateUpdatePersonDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}