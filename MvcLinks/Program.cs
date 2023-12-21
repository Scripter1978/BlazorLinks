using Azure.Identity;
using Core.Context;
using Core.Repositories;
using Htmx.TagHelpers;
using Infrastructure.Services;
using Infrastructure.Services.Interfaces;
using Infrastructure.Services.Public;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Supabase;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContextFactory<LinksDbContext>(
    options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);

builder.Services.AddScoped<IPublicRepository, PublicRepository>();
builder.Services.AddScoped<IUniqueIdService, UniqueIdService>();
builder.Services.AddScoped<IPublicService, PublicService>();


// ---------- SUPABASE
var url = "https://pylnesfgmytjegzzculn.supabase.co";
var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InB5bG5lc2ZnbXl0amVnenpjdWxuIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NjgyOTMwMzcsImV4cCI6MTk4Mzg2OTAzN30.kI29Q_qYWDH5SD6oi5NTwHG6Pxy1e1AUfR8s_ga45lE";

builder.Services.AddScoped<Supabase.Client>(
    provider => new Supabase.Client(
        url,
        key,
        new Supabase.SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = true,
            SessionHandler = new DefaultSupabaseSessionHandler(),
             
        }
    )
);

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