using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationService.User;
using Store.Dto;
using System.Xml.Linq;

namespace Store.UnitTest
{
    [TestFixture]
    public class UserTest
    {
        protected TestServer server;

        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            
        }

        [Test]
        public void GetAllUserTest()
        {
            var repository = server.Host.Services.GetService<IUserApplicationService>();

            var list= repository.GetAllUserAsync();

            Assert.Pass();
        }

        [Test]

        public void GetUserTest()
        {
            var repository = server.Host.Services.GetService<IUserApplicationService>();

            var user = repository.GetUserAsync(1);

            Assert.Pass();
        }

        [Test]
        public void DeleteUserTest()
        {
            var repository = server.Host.Services.GetService<IUserApplicationService>();

            var deleteuser = repository.DeleteUserAsync(1);

            Assert.Pass();
        }


        public void AddUserTest() {

            var repository = server.Host.Services.GetService<IUserApplicationService>();

            userDto UserDtoTest = new userDto();
            {
                Name = "ismael",
                LastName = "Martinez",
                Phone = ""



            };


        }


        public void UpdateUserTest() {
            var repository = server.Host.Services.GetService<IUserApplicationService>();
            userDto UserDtoTest = new userDto();
        }
    }
}