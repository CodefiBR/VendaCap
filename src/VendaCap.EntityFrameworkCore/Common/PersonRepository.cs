using System;
using System.Linq;
using System.Threading.Tasks;
using VendaCap.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace VendaCap.Common;

public class PersonRepository : EfCoreRepository<VendaCapDbContext, Person, Guid>, IPersonRepository
{
    public PersonRepository(IDbContextProvider<VendaCapDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Person>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}