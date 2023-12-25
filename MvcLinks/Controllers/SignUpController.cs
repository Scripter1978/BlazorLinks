using Microsoft.AspNetCore.Mvc;

namespace MvcLinks.Controllers;

public class SignUpController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        return View();
    }
}