using Microsoft.AspNetCore.Builder;
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
using Store.DataAccess;
using Store.DataAccess.Repositories;
using AutoMapper;
using Serilog;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<StoreDataContext>(options =>
                options.UseInMemoryDatabase("DatabaeTest")
                );

builder.Services.AddTransient<ISaleDetailsApplicationService, SaleDetailsApplicationService>();
builder.Services.AddTransient<ISaleApplicationService, SaleApplicationService>();
builder.Services.AddTransient<IUserApplicationService, UserApplicationService>();
builder.Services.AddTransient<IBrandApplicationService, BrandApplicationService>();
builder.Services.AddTransient<ICategoryApplicationService, CategoryApplicationService>();
builder.Services.AddTransient<IProductApplicationService, ProductApplicationService>();

builder.Services.AddTransient<IRepository<int, brand>, Repository<int, brand>>();
builder.Services.AddTransient<IRepository<int, category>, Repository<int, category>>();
builder.Services.AddTransient<IRepository<int, product>, ProductRepository>();
builder.Services.AddTransient<IRepository<int, user>, Repository<int, user>>();
builder.Services.AddTransient<IRepository<int, sale>, SaleRepository>();
builder.Services.AddTransient<IRepository<int, sale_detail>, SaleDetailRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
