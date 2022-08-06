using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendaCap.Common;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.Place.ViewModels;

namespace VendaCap.Web.Pages.Common.Place;

public class EditModalModel : VendaCapPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public int Id { get; set; }

    [BindProperty]
    public CreateEditPlaceViewModel ViewModel { get; set; }

    private readonly IPlaceAppService _service;

    public EditModalModel(IPlaceAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<PlaceDto, CreateEditPlaceViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditPlaceViewModel, CreateUpdatePlaceDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}