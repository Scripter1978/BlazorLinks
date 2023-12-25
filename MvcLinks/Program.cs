using Azure.Identity; 
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

//
// builder.Services.AddDbContextFactory<LinksDbContext>(
//     options =>
//         options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);
//  
builder.Services.AddScoped<IUniqueIdService, UniqueIdService>();
builder.Services.AddScoped<IPublicService, PublicService>();


// ---------- SUPABASE
var url = "https://yjhcoittdmimcaxtffer.supabase.co";
var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InlqaGNvaXR0ZG1pbWNheHRmZmVyIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MDMwMjU4MTUsImV4cCI6MjAxODYwMTgxNX0.6zH8NNxUhDL_thuLK_xyHMzY6eHQfbiz54z_VohEgOs";

builder.Services.AddScoped<Supabase.Client>(
    provider => new Supabase.Client(
        url,
        key,
        new Supabase.SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = true
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