using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Empire.Models;

namespace Empire.Controllers
{
    public class ArtistController : Controller
    {
      [HttpGet("/artist")]
      public ActionResult Index()
      {
        List<Artist> allArtists = Artist.GetAll();
          return View("ArtistDetails", allArtists);
      }
      [HttpGet("/artist/new")]
      public ActionResult ArtistForm()
      {
        return View();
      }
      [HttpPost("/artist/new")]
      public ActionResult Create(string artistName)
      {
        Artist newArtist = new Artist(artistName);
        List<Artist> allArtists = Artist.GetAll();
        return View("ArtistDetails", allArtists);
      }

      [HttpGet("/artist/{id}")]
      public ActionResult AddDetails(int id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Artist selectedArtist = Artist.Find(id);
        List<Artist> CDArtist = Artist.GetArtists();
        model.Add("artist", selectedArtist);
        return View(model);
      }
    }
}
