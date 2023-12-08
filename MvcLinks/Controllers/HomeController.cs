using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MvcLinks.Controllers;

public class HomeController(ILogger<HomeController> logger, IUniqueIdService uniqueIdService) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    private readonly IUniqueIdService _uniqueIdService = uniqueIdService;

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
}