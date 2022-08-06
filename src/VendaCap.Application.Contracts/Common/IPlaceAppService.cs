using System;
using VendaCap.Common.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VendaCap.Common;

public interface IPlaceAppService :
    ICrudAppService< 
        PlaceDto, 
        int, 
        PagedAndSortedResultRequestDto,
        CreateUpdatePlaceDto,
        CreateUpdatePlaceDto>
{

}