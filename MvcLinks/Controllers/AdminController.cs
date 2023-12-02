using System.Diagnostics;
using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MvcLinks.Models;

namespace MvcLinks.Controllers
{
    public class AdminController(ILogger<HomeController> logger, IUniqueIdService uniqueIdService) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IUniqueIdService _uniqueIdService = uniqueIdService;
        // GET: Admin
        public ActionResult Index()
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
                    Id = _uniqueIdService.Generator()
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
}
