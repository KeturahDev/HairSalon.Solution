using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
//controller class names have to be singular of the models to commect with Views!
  {
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db) 
    {
      _db = db;
    }

    public ActionResult Create(int id)
    {
      Stylist stylistOfClient = _db.Stylists.FirstOrDefault(stylist => stylist.Id == id);
      ViewBag.Stylist = stylistOfClient;
      return View();
    }
  }
}