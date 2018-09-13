using Microsoft.AspNetCore.Mvc;

namespace Empire.Controllers
{
    public class ArtistController : Controller
    {
      [HttpGet("/artist/new")]
      public ActionResult ArtistForm()
      {
          return View();
      }
    }
}
