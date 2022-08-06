using System;
using VendaCap.Permissions;
using VendaCap.Common.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VendaCap.Common;

public class PlaceAppService : CrudAppService<Place, PlaceDto, int, PagedAndSortedResultRequestDto, CreateUpdatePlaceDto, CreateUpdatePlaceDto>,
    IPlaceAppService
{
    protected override string GetPolicyName { get; set; } = VendaCapPermissions.Place.Default;
    protected override string GetListPolicyName { get; set; } = VendaCapPermissions.Place.Default;
    protected override string CreatePolicyName { get; set; } = VendaCapPermissions.Place.Create;
    protected override string UpdatePolicyName { get; set; } = VendaCapPermissions.Place.Update;
    protected override string DeletePolicyName { get; set; } = VendaCapPermissions.Place.Delete;

    private readonly IPlaceRepository _repository;

    public PlaceAppService(IPlaceRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
