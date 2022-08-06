using System;
using VendaCap.Permissions;
using VendaCap.Common.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VendaCap.Common;

public class PersonAppService : CrudAppService<Person, PersonDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePersonDto, CreateUpdatePersonDto>,
    IPersonAppService
{
    protected override string GetPolicyName { get; set; } = VendaCapPermissions.Person.Default;
    protected override string GetListPolicyName { get; set; } = VendaCapPermissions.Person.Default;
    protected override string CreatePolicyName { get; set; } = VendaCapPermissions.Person.Create;
    protected override string UpdatePolicyName { get; set; } = VendaCapPermissions.Person.Update;
    protected override string DeletePolicyName { get; set; } = VendaCapPermissions.Person.Delete;

    private readonly IPersonRepository _repository;

    public PersonAppService(IPersonRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
