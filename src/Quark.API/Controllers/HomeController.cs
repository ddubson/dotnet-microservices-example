using Microsoft.AspNetCore.Mvc;

namespace Quark.API.Controllers
{
    [Route("/")]
    public class HomeController: Controller
    {
        public IActionResult Get()
        {
            return Content("Hello from Quark API");
        }
    }
}