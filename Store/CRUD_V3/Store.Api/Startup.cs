using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Store.ApplicationService.Brand;
using Store.ApplicationService.Category;
using Store.ApplicationService.Product;
using Store.ApplicationService.Sale;
using Store.ApplicationService.Sale_Detail;
using Store.ApplicationService.User;
using Store.Core.Inventories;
using Store.Core.Sale;
using Store.Core.User;
using Store.DataAccess;
using Store.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<StoreDataContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

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


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Store.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Store.Api v1"));
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
