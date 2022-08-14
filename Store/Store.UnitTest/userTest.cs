using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

using NUnit.Framework;
using Store.ApplicationService.User;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Store.UnitTest
{
    [TestFixture]
    public class Tests
    {
        //protected  TestServer server;
        private HttpClient _httpClient;

        [OneTimeSetUp]
        public void Setup()
        {
            //this.server = new TestServer(new  WebHostBuilder().UseStartup<Program>());

            var webAppFactory = new WebApplicationFactory<Program>()
       .WithWebHostBuilder(builder => builder
           .ConfigureServices(services =>
           {
               services.AddTransient<IUserApplicationService, UserApplicationService>();
           }));
            _httpClient = webAppFactory.CreateDefaultClient();
        }

        [Test]
        public void Getallusers()
        {

            var result = _httpClient.GetAsync("/User");
            Assert.IsNotNull(result);

            /*var repository = server.Host.Services.GetService<IUserApplicationService>();

            var list = repository.GetAllUserAsync();

            Assert.Pass();*/
        }
    }
}