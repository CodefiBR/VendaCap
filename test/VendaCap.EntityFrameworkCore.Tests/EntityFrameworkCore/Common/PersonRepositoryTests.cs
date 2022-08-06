using System;
using System.Threading.Tasks;
using VendaCap.Common;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace VendaCap.EntityFrameworkCore.Common;

public class PersonRepositoryTests : VendaCapEntityFrameworkCoreTestBase
{
    private readonly IPersonRepository _personRepository;

    public PersonRepositoryTests()
    {
        _personRepository = GetRequiredService<IPersonRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
