using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace VendaCap.Common;

public class PersonAppServiceTests : VendaCapApplicationTestBase
{
    private readonly IPersonAppService _personAppService;

    public PersonAppServiceTests()
    {
        _personAppService = GetRequiredService<IPersonAppService>();
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

