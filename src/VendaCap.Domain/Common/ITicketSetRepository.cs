using System;
using Volo.Abp.Domain.Repositories;

namespace VendaCap.Common;

public interface ITicketSetRepository : IRepository<TicketSet, Guid>
{
}
