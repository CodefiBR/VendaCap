using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.TicketSet.ViewModels;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.Person.ViewModels;
using VendaCap.Common.Dtos;
using VendaCap.Web.Pages.Common.Place.ViewModels;
using AutoMapper;

namespace VendaCap.Web;

public class VendaCapWebAutoMapperProfile : Profile
{
    public VendaCapWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<TicketSetDto, CreateEditTicketSetViewModel>();
        CreateMap<CreateEditTicketSetViewModel, CreateUpdateTicketSetDto>();
        CreateMap<PersonDto, CreateEditPersonViewModel>();
        CreateMap<CreateEditPersonViewModel, CreateUpdatePersonDto>();
        CreateMap<PlaceDto, CreateEditPlaceViewModel>();
        CreateMap<CreateEditPlaceViewModel, CreateUpdatePlaceDto>();
    }
}
