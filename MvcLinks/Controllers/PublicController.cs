using Core.Enums;
using Infrastructure.Services.Interfaces;
using Infrastructure.Services.Public;
using Microsoft.AspNetCore.Mvc;
using MvcLinks.Models;

namespace MvcLinks.Controllers;

public class PublicController(ILogger<HomeController> logger, IUniqueIdService _uniqueIdService, IPublicService publicService) : Controller
{
    // GET
    [Route("/{id?}")]
    public async Task<IActionResult> Index(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            return NotFound();
        }
        if(id[..1] == "@")
        {
            id = id[1..];
        }
        var bio = await publicService.GetBio(id);
        if(bio is null)
        {
            return NotFound();
        }
        
        var profileDate = new ProfileData
        {
            Bio = "My bio",
            UserName = "@myusername",
            Website = "https://mywebsite.com",
            ProfileImagePath = "https://ugc.production.linktr.ee/195b7775-a1d7-4252-bc93-d85d4ca796b3_WP-20141201-002.jpeg?io=true&size=avatar-v1_0",
            JpgImageName = "profile.jpg",
            PngImageName = "profile.png",
            LinkItems = new List<LinkItem>
            {
                new()
                {
                    Url = "https://mywebsite.com",
                    Description = "My website",
                    ImagePath = "https://mywebsite.com/images/website.jpg",
                    LinkType = "Website",
                    Order = 1,
                    Text = "My website",
                    CssClass = $"{_uniqueIdService.Generator(UniqueIdType.Link)}"
                },
                new()
                {
                    Url = "https://twitter.com/myusername",
                    Description = "My Twitter",
                    ImagePath = "https://mywebsite.com/images/twitter.jpg",
                    LinkType = "Twitter",
                    Order = 2,
                    Text = "My Twitter",
                    CssClass = $"{_uniqueIdService.Generator(UniqueIdType.Link)}"
                }
            }
        };
        return View(profileDate);
    }
    
}