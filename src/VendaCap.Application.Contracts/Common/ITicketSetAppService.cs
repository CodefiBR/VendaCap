using System;
using VendaCap.Common.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VendaCap.Common;

public interface ITicketSetAppService :
    ICrudAppService< 
        TicketSetDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateUpdateTicketSetDto,
        CreateUpdateTicketSetDto>
{

}