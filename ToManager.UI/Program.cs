using Bussnes.Layer.Abstract;
using Bussnes.Layer.Concrete;
using Microsoft.EntityFrameworkCore;
using ToManage.EntityLayer;
using ToManager.DataAccess.Layer;
using ToManager.DataAccess.Layer.Abstract;
using ToManager.DataAccess.Layer.EntityFramework;
using ToManager.DataAccess.Layer.Repositories;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddScoped<IGoodsCategoryService, GoodsCategoryService>();
builder.Services.AddScoped<IGoodsCategoryDAL, EfGoodsCategoryRepository>();
builder.Services.AddScoped<ICategoryDetailService, CategoryDetailService>();
builder.Services.AddScoped<ICategoryDetailDAL, EfCategoryDetailRepository>();


builder.Services.AddScoped<IGoodsService, GoodsService>();
builder.Services.AddScoped<IGoodsDAL, EfGoodsRepository>();
builder.Services.AddScoped<Context>();

builder.Services.AddScoped(typeof(GenericRepository<>));

builder.Services.AddControllersWithViews();
var configuration = builder.Configuration;
builder.Services.AddDbContext<Context>(options =>
options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
);


/*
services.AddTransient<IGoodsCategoryService, GoodsCategoryService>();
services.AddTransient<GenericRepository<GoodsCategory>>();
services.AddTransient<IGoodsCategoryDAL, YourGoodsCategoryDALImplementation>();

*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=GoodsCategory}/{action=Index}/{id?}");

app.Run();
