using Microsoft.AspNetCore.Mvc;

namespace RazorLinks.Controllers;

public class LinksController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}