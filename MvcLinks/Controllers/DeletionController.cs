using Microsoft.AspNetCore.Mvc;

namespace MvcLinks.Controllers
{
    public class DeletionController : Controller
    {
        [HttpDelete]
        // GET: DeletionController
        public ActionResult Index()
        {
            return Ok();
        }
        [HttpDelete]
        // GET: DeletionController
        public ActionResult DeleteLink()
        {
            return Ok();
        }
    }
}
