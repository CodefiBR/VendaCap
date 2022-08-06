using System;
using System.Linq;
using System.Threading.Tasks;
using VendaCap.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace VendaCap.Common;

public class TicketSetRepository : EfCoreRepository<VendaCapDbContext, TicketSet, Guid>, ITicketSetRepository
{
    public TicketSetRepository(IDbContextProvider<VendaCapDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<TicketSet>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}