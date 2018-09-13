using Microsoft.AspNetCore.Mvc;

namespace Empire.Controllers
{
    public class CDController : Controller
    {
      [HttpGet("/cd")]
      public ActionResult CDForm()
      {
          return View();
      }
    }
}
