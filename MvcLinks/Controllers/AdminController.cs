using System.Diagnostics;
using Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MvcLinks.Models;

namespace MvcLinks.Controllers
{
    public class AdminController(ILogger<HomeController> logger, IUniqueIdService _uniqueIdService) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            return View();
        } 

        public async Task<IActionResult> AddLink(LinkPayload? payload)
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
        public async Task<IActionResult> AddLinkPost(LinkPayload payload)
        {
            ViewData["payload"] = payload;
            return PartialView();
        }
        public async Task<IActionResult> Upload(LinkPayload payload)
        {
            // TODO: Upload file
            // TODO: Save file path to database
            // TODO: Return file path to view
            // TODO: Check for existing file
            ViewData["payload"] = payload;
            return PartialView();
        }

        public async Task<IActionResult> UploadPost(LinkPayload payload)
        {
            
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
