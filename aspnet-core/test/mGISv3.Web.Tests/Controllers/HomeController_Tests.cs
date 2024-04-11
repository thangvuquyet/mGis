using System.Threading.Tasks;
using mGISv3.Models.TokenAuth;
using mGISv3.Web.Controllers;
using Shouldly;
using Xunit;

namespace mGISv3.Web.Tests.Controllers
{
    public class HomeController_Tests: mGISv3WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}