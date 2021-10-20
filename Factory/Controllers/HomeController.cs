using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;
      public HomeController(FactoryContext db)
    {
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        dynamic model = new ExpandoObject();
        model.Machines = _db.Machines.ToList();
        model.Engineers = _db.Engineers.ToList();
        return View(model);
      }

    }
}