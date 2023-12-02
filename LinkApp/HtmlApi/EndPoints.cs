using LinkApp.HtmlApi.Components;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LinkApp.HtmlApi;

public static class Endpoints
{
    public static void Map(WebApplication app)
    {
        // app.MapGet("/add-link",
        //     async (BlazorRenderer renderer) =>
        //     {
        //         var rendered = await renderer.RenderComponent<AddLink>();
        //         return Results.Content(rendered, "text/html");
        //     });
        app.MapGet("/add-link",(IAntiforgery forgeryService, HttpContext context)=>
        {
            var tokens = forgeryService.GetAndStoreTokens(context);
            context.Response.Headers.Append("XSRF-TOKEN", tokens.RequestToken!);
            return new RazorComponentResult<AddLink>(tokens.RequestToken);
        });
        
        app.MapGet("/add-link2",()=>
        {
            return new RazorComponentResult<AddLink2>();
        });
        app.MapGet("/hello",
            async (BlazorRenderer renderer) =>
            {
                await Task.Delay(2000);
                return Results.Content(await renderer.RenderComponent<HelloWorld>(), "text/html");
            });
               
        
        app.MapPost("/add-link2",
            async ([FromForm] LinkPayload data) =>
            { 
                return new RazorComponentResult<AddLink2>(data);
            });
        
        // app.MapPost("/message",
        //     async (BlazorRenderer renderer) =>
        //     {
        //         await Task.Delay(2000);
        //         return Results.Content(await renderer.RenderComponent<HelloWorld>(), "text/html");
        //     });
        //
        //
        //
        //
        // app.MapPost("/upload", async (IFormFile file, BlazorRenderer renderer) =>
        //     {
        //         var parameters = new Dictionary<string, object?>
        //         {
        //             {nameof(UploadResult.File), file}
        //         };
        //         return Results.Content(await renderer.RenderComponent<UploadResult>(parameters), "text/html");
        //     }
        // );
    }
}