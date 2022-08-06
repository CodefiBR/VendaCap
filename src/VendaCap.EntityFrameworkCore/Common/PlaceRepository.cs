using System;
using System.Linq;
using System.Threading.Tasks;
using VendaCap.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace VendaCap.Common;

public class PlaceRepository : EfCoreRepository<VendaCapDbContext, Place, int>, IPlaceRepository
{
    public PlaceRepository(IDbContextProvider<VendaCapDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Place>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}