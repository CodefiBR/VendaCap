using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VendaCap.Common;

public static class PersonEfCoreQueryableExtensions
{
    public static IQueryable<Person> IncludeDetails(this IQueryable<Person> queryable, bool include = true)
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
