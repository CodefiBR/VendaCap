using System;
using System.Threading.Tasks;
using VendaCap.Common;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace VendaCap.EntityFrameworkCore.Common;

public class PlaceRepositoryTests : VendaCapEntityFrameworkCoreTestBase
{
    private readonly IPlaceRepository _placeRepository;

    public PlaceRepositoryTests()
    {
        _placeRepository = GetRequiredService<IPlaceRepository>();
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
