using Htmx.TagHelpers;
using HtmxBlazor.Components;
using Infrastructure.Services.Public;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapHtmxAntiforgeryScript();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();