using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendaCap.Common;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.Place.ViewModels;

namespace VendaCap.Web.Pages.Common.Place;

public class CreateModalModel : VendaCapPageModel
{
    [BindProperty]
    public CreateEditPlaceViewModel ViewModel { get; set; }

    private readonly IPlaceAppService _service;

    public CreateModalModel(IPlaceAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditPlaceViewModel, CreateUpdatePlaceDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}