using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationService.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UnitTest
{
    public class ProductTest
    {
        protected TestServer server;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }
        [Test]
        public void GetAllProductsTest()
        {
            var repository = server.Host.Services.GetService<IProductApplicationService>();
            var list = repository.GetAllProductAsync();
        }

        [Test]
        public void GetProductTest()
        {
            var repository = server.Host.Services.GetService<IProductApplicationService>();
            var product = repository.GetProductAsync(1);

            Assert.Pass();
        }

        [Test]

        public void DeleteProductTest()
        {
            var repository = server.Host.Services.GetService<IProductApplicationService>();
            var deleteproduct = repository.DeleteProductAsync(1);

            Assert.Pass();
        }

        public void AddProductTest()
        {
            var repository = server.Host.Services.GetService<IProductApplicationService>();
        }

        public void UpdateProductTest()
        {
            var repository = server.Host.Services.GetService<IProductApplicationService>();
        }
    }
}
