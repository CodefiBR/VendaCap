using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace VendaCap.Common
{
    public class TicketSet : AuditedAggregateRoot<Guid>
    {
        public DateTime DrawDate { set; get; }
        public int Amount { set; get; }
        public Decimal Price { set; get; }
        public Product Product { set; get; }

        protected TicketSet()
        {
        }

        public TicketSet(
            Guid id,
            DateTime drawDate,
            int amount,
            Decimal price,
            Product product
        ) : base(id)
        {
            DrawDate = drawDate;
            Amount = amount;
            Price = price;
            Product = product;
        }
    }
}
