using System;
using VendaCap.Common.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VendaCap.Common;

public interface IPersonAppService :
    ICrudAppService< 
        PersonDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        CreateUpdatePersonDto,
        CreateUpdatePersonDto>
{

}