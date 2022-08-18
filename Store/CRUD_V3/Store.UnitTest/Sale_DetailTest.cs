using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationService.Sale_Detail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UnitTest
{
    public class Sale_DetailTest
    {
        protected TestServer server;

        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }
        [Test]
        public void GetAllDetailsSalesTest()
        {
            var repository = server.Host.Services.GetService<ISaleDetailsApplicationService>();
            var list = repository.GetAllSaleDetailAsync();

            Assert.Pass();
        }
        [Test]
        public void GetDetilSaleTest()
        {
            var repository = server.Host.Services.GetService<ISaleDetailsApplicationService>();

            var saledetail = repository.GetSaleDetailAsync(1);
            Assert.Pass();
        }

        [Test]

        public void DeleteDetailSaleTest()
        {
            var repository = server.Host.Services.GetService<ISaleDetailsApplicationService>();
            var deletesaledetail = repository.DeleteSaleDetailAsync(1);

            Assert.Pass();
        }

    }
}
