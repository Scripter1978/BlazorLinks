using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcLinks.Models;

namespace MvcLinks.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Links()
    {
        return View();
    }

    public IActionResult AddLink(LinkPayload? payload)
    {
        if (!string.IsNullOrWhiteSpace(payload.Id))
        {
            ViewData["payload"] = payload;
        }
        else
        {
            ViewData["payload"] = new LinkPayload
            {
                Id = Guid.NewGuid().ToString()
            };
        }
        return PartialView();
    }
    public IActionResult AddLinkPost(LinkPayload payload)
    {
        ViewData["payload"] = payload;
        return PartialView();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}