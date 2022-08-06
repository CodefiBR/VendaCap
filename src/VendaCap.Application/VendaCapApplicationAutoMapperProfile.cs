using VendaCap.Common;
using VendaCap.Common.Dtos;
using AutoMapper;

namespace VendaCap;

public class VendaCapApplicationAutoMapperProfile : Profile
{
    public VendaCapApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<TicketSet, TicketSetDto>();
        CreateMap<CreateUpdateTicketSetDto, TicketSet>(MemberList.Source);
        CreateMap<Person, PersonDto>();
        CreateMap<CreateUpdatePersonDto, Person>(MemberList.Source);
        CreateMap<Place, PlaceDto>();
        CreateMap<CreateUpdatePlaceDto, Place>(MemberList.Source);
    }
}
