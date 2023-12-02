using Htmx.TagHelpers;
using LinkApp.Components;
using LinkApp.HtmlApi;
using Microsoft.AspNetCore.Components.Web;
using HtmxEndPoints = LinkApp.HtmlApi.Endpoints;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN");
builder.Services.AddScoped<HtmlRenderer>();
builder.Services.AddScoped<BlazorRenderer>();
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
app.MapRazorComponents<App>();
HtmxEndPoints.Map(app);
app.Run();