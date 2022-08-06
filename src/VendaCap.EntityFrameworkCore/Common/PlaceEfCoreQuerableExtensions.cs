using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VendaCap.Common;

public static class PlaceEfCoreQueryableExtensions
{
    public static IQueryable<Place> IncludeDetails(this IQueryable<Place> queryable, bool include = true)
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
