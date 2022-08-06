using System;
using Volo.Abp.Application.Dtos;

namespace VendaCap.Common.Dtos;

[Serializable]
public class TicketSetDto : AuditedEntityDto<Guid>
{
    public DateTime DrawDate { get; set; }

    public int Amount { get; set; }

    public Decimal Price { get; set; }
}