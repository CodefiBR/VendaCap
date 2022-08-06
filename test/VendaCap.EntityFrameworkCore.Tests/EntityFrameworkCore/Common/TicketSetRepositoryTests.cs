using System;
using System.Threading.Tasks;
using VendaCap.Common;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace VendaCap.EntityFrameworkCore.Common;

public class TicketSetRepositoryTests : VendaCapEntityFrameworkCoreTestBase
{
    private readonly ITicketSetRepository _ticketSetRepository;

    public TicketSetRepositoryTests()
    {
        _ticketSetRepository = GetRequiredService<ITicketSetRepository>();
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
