using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace VendaCap.Common
{
    public class Ticket : AuditedAggregateRoot<Guid>
    {
        public TicketSet TicketSet { get; set; }
        public Person Person { get; set; }
    }
}
