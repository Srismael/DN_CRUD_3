using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationService.Brand;
using Store.Core.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Store.UnitTest
{
    public class BrandTest
    {
        protected TestServer server;

        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Test]
        public void GetAllBrandsTest()
        {
            var repository = server.Host.Services.GetService<IBrandApplicationService>();
            var list = repository.GetAllBrandAsync();

            Assert.Pass();


        }

        [Test]
        public void GetBrandTest()
        {

            var repository = server.Host.Services.GetService<IBrandApplicationService>();
            var brand = repository.GetBrandAsync(1);

            Assert.Pass();

        }

        [Test]
        public void DeleteBrandTest()
        {
            var repository = server.Host.Services.GetService<IBrandApplicationService>();
            var deletebrand = repository.DeleteBrandAsync(1);

            Assert.Pass();

        }

        public void AddBrandTest()
        {
            var repository = server.Host.Services.GetService<IBrandApplicationService>();

            product productTest = new product {
                Id = 1,
                Name = "laptop",
                Stock = 11,
                Description = "laptop eficaas", 
                Price = 23000,

                
            };

            brand brandTest = new brand
            {
                Id = 1,
                Name = "Microsoft",
                Description = "marca",
                


            };



           // var addbrand = repository.AddBrandAsync(brand);
        }

    }
}
