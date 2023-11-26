using LinkApp.HtmlApi.Components;
using Microsoft.AspNetCore.Mvc;

namespace LinkApp.HtmlApi;

public static class Endpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/add-link",
            async (BlazorRenderer renderer) =>
            {
                await Task.Delay(2000);
                return Results.Content(await renderer.RenderComponent<AddLink>(), "text/html");
            });
               
        app.MapPost("/add-link",
            async ([FromForm] Payload data, BlazorRenderer renderer) =>
            {
                var parameters = new Dictionary<string, object?>
                {
                    {nameof(WithPayload.Data), data}
                };
                return Results.Content(await renderer.RenderComponent<WithPayload>(parameters), "text/html");
            });
        
        app.MapPost("/message",
            async (BlazorRenderer renderer) =>
            {
                await Task.Delay(2000);
                return Results.Content(await renderer.RenderComponent<HelloWorld>(), "text/html");
            });

        
       

        app.MapPost("/upload", async (IFormFile file, BlazorRenderer renderer) =>
            {
                var parameters = new Dictionary<string, object?>
                {
                    {nameof(UploadResult.File), file}
                };
                return Results.Content(await renderer.RenderComponent<UploadResult>(parameters), "text/html");
            }
        );
    }
}