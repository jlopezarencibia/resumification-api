using System.Threading.Tasks;
using Resumification.Models.TokenAuth;
using Resumification.Web.Controllers;
using Shouldly;
using Xunit;

namespace Resumification.Web.Tests.Controllers
{
    public class HomeController_Tests: ResumificationWebTestBase
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