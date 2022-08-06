using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace VendaCap.Common
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public String Name { get; set; }
        public String InternalName { get; set; }
        public Decimal Price { get; set; }
        public bool IsActivated { get; set; }
    }
}
