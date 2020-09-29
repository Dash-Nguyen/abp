using System.Threading.Tasks;
using Dash-ABP.Models.TokenAuth;
using Dash-ABP.Web.Controllers;
using Shouldly;
using Xunit;

namespace Dash-ABP.Web.Tests.Controllers
{
    public class HomeController_Tests: Dash-ABPWebTestBase
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