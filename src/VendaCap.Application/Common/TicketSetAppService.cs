using System;
using VendaCap.Permissions;
using VendaCap.Common.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VendaCap.Common;

public class TicketSetAppService : CrudAppService<TicketSet, TicketSetDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTicketSetDto, CreateUpdateTicketSetDto>,
    ITicketSetAppService
{
    protected override string GetPolicyName { get; set; } = VendaCapPermissions.TicketSet.Default;
    protected override string GetListPolicyName { get; set; } = VendaCapPermissions.TicketSet.Default;
    protected override string CreatePolicyName { get; set; } = VendaCapPermissions.TicketSet.Create;
    protected override string UpdatePolicyName { get; set; } = VendaCapPermissions.TicketSet.Update;
    protected override string DeletePolicyName { get; set; } = VendaCapPermissions.TicketSet.Delete;

    private readonly ITicketSetRepository _repository;

    public TicketSetAppService(ITicketSetRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
