using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace VendaCap.Common;

public class TicketSetAppServiceTests : VendaCapApplicationTestBase
{
    private readonly ITicketSetAppService _ticketSetAppService;

    public TicketSetAppServiceTests()
    {
        _ticketSetAppService = GetRequiredService<ITicketSetAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

