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


var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog();


/*var logger = new LoggerConfiguration()
  .WriteTo.MySQL(
    "default")
  .CreateLogger();*/



string connectionString = builder.Configuration.GetConnectionString("Default");
//string connectionString = builder.Configuration.GetConnectionString("Docker");
//string connectionString = builder.Configuration.GetConnectionString("");


builder.Services.AddDbContext<StoreDataContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

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

//builder.Services.AddTransient<IRepository<int, Profile>, ProfilesRepository>();
//builder.Services.AddAutoMapper(typeof(Store.ApplicationService.MapperProfile));




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()   )
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

IConfiguration configuration = app.Configuration;

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<StoreDataContext>();
    db.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
