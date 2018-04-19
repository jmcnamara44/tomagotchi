using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult CreateForm()
      {

        return View();
      }

      [HttpPost("/tamagotchi")]
      public ActionResult Index()
      {
        //Instance of Tamagotchi.cs or Pet Object
        Pet newPet = new Pet("Test");
        newPet.SetName(Request.Form["new-name"]);
        return View(newPet);
      }

      [HttpGet("/tamagotchi/update")]
      public ActionResult UpdateTamagotchi()
      {
        Pet newPet =new Pet("name");
        newPet.PassTime();
        return View("Index", newPet);
      }

    }
}
