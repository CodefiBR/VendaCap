using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VendaCap.Common;

public static class TicketSetEfCoreQueryableExtensions
{
    public static IQueryable<TicketSet> IncludeDetails(this IQueryable<TicketSet> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
