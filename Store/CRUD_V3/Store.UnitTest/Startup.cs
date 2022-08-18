using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Store.ApplicationService.Brand;
using Store.ApplicationService.Category;
using Store.ApplicationService.Product;
using Store.ApplicationService.Sale;
using Store.ApplicationService.Sale_Detail;
using Store.ApplicationService.User;
using Store.Core.Inventories;
using Store.Core.Sale;
using Store.Core.User;
using Store.DataAccess.Repositories;
using Store.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.UnitTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<StoreDataContext>(options =>
                options.UseInMemoryDatabase("DataTest")
                );

            services.AddTransient<ISaleDetailsApplicationService, SaleDetailsApplicationService>();
            services.AddTransient<ISaleApplicationService, SaleApplicationService>();
            services.AddTransient<IUserApplicationService, UserApplicationService>();
            services.AddTransient<IBrandApplicationService, BrandApplicationService>();
            services.AddTransient<ICategoryApplicationService, CategoryApplicationService>();
            services.AddTransient<IProductApplicationService, ProductApplicationService>();

            services.AddTransient<IRepository<int, brand>, Repository<int, brand>>();
            services.AddTransient<IRepository<int, category>, Repository<int, category>>();
            services.AddTransient<IRepository<int, product>, ProductRepository>();
            services.AddTransient<IRepository<int, user>, Repository<int, user>>();
            services.AddTransient<IRepository<int, sale>, SaleRepository>();
            services.AddTransient<IRepository<int, sale_detail>, SaleDetailRepository>();


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                
                
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
