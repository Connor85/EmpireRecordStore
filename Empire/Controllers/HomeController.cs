using Microsoft.AspNetCore.Mvc;

namespace Empire.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
