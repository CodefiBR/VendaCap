using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendaCap.Common;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.Person.ViewModels;

namespace VendaCap.Web.Pages.Common.Person;

public class CreateModalModel : VendaCapPageModel
{
    [BindProperty]
    public CreateEditPersonViewModel ViewModel { get; set; }

    private readonly IPersonAppService _service;

    public CreateModalModel(IPersonAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditPersonViewModel, CreateUpdatePersonDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}