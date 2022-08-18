using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationService.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UnitTest
{
    public class SaleTest
    {
        protected TestServer server;

        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }
        [Test]
        public void GetAllSalesTest()
        {
            var repository = server.Host.Services.GetService<ISaleApplicationService>();

            var list = repository.GetAllSaleAsync();
            Assert.Pass();
        }
        [Test]
        public void GetSaleTest()
        {
            var repository = server.Host.Services.GetService<ISaleApplicationService>();

            var sale = repository.GetSaleAsync(1);

            Assert.Pass();
        }

        [Test]

        public void DeleteSaleTest()
        {
            var repository = server.Host.Services.GetService<ISaleApplicationService>();

            var deletesale = repository.DeleteSaleAsync(1);

            Assert.Pass();
        }

    }
}
