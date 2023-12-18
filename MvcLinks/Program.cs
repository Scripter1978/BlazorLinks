using Azure.Identity;
using Core.Context;
using Core.Repositories;
using Htmx.TagHelpers;
using Infrastructure.Services;
using Infrastructure.Services.Interfaces;
using Infrastructure.Services.Public;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContextFactory<LinksDbContext>(
    options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);

builder.Services.AddScoped<IPublicRepository, PublicRepository>();
builder.Services.AddScoped<IUniqueIdService, UniqueIdService>();
builder.Services.AddScoped<IPublicService, PublicService>();
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
app.MapHtmxAntiforgeryScript();

app.MapControllerRoute( 
    name: "public",
    pattern: "{controller=Public}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action}/");

app.Run();