using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistController(HairSalonContext db)
    {        
      _db = db;
    }
    public ActionResult Index() 
    {
      List<Stylist> stylistsList = _db.Stylists.ToList();
      return View(stylistsList);
    }
  }
}