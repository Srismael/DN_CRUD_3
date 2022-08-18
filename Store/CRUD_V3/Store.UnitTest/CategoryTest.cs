using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Store.ApplicationService.Brand;
using Store.ApplicationService.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UnitTest
{
    public class CategoryTest
    {
        protected TestServer server;

        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }
        [Test]
        public void GetAllCategoriesTest()
        {
            var repository = server.Host.Services.GetService<ICategoryApplicationService>();
            var list = repository.GetAllCategoryAsync();

            Assert.Pass();

        }

        [Test]
        public void GetCategoryTest()
        {
            var repository = server.Host.Services.GetService<ICategoryApplicationService>();
            var category = repository.GetCategoryAsync(1);
            Assert.Pass();
        }

        [Test]

        public void DeleteCategoryTest()
        {
            var repository = server.Host.Services.GetService<ICategoryApplicationService>();
            var deletecategory = repository.DeleteCategoryAsync(1);

            Assert.Pass();
        }

        public void AddCategoryTest()
        {
            var repository = server.Host.Services.GetService<ICategoryApplicationService>();
            //var addcategory = repository.AddCategoryAsync(1, "hola", "Marca ", 1);
        }

    }
}
