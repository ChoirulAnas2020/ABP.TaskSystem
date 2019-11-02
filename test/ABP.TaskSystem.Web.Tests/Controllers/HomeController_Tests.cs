using System.Threading.Tasks;
using ABP.TaskSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABP.TaskSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: TaskSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
