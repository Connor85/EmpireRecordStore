using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Empire.Models;

namespace Empire.Controllers
{
    public class CDController : Controller
    {
      [HttpGet("/cd/new")]
      public ActionResult CDForm()
      {
          return View();
      }

      [HttpPost("/cd/new")]
      public ActionResult Create(string cdTitle)
      {
        CD newCD = new CD(cdTitle);
        List<CD> allCDs = CD.GetAll();
        return View("CDDetails",allCDs);
      }

      [HttpGet("/CD/{id}")]
      public ActionResult AddDetails(int id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        CD selectedCD = CD.Find(id);
        List<CD> CDTitle = CD.GetCD();
        model.Add("cd", selectedCD);
        return View(model);
      }
    }
}
