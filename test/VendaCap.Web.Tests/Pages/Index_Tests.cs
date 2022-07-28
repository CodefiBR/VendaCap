using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace VendaCap.Pages;

public class Index_Tests : VendaCapWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
