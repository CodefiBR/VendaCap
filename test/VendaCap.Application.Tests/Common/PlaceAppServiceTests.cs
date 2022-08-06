using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace VendaCap.Common;

public class PlaceAppServiceTests : VendaCapApplicationTestBase
{
    private readonly IPlaceAppService _placeAppService;

    public PlaceAppServiceTests()
    {
        _placeAppService = GetRequiredService<IPlaceAppService>();
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

