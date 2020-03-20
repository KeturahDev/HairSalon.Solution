using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
//controller class names have to be singular of the models to connect with Views!
  {
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db) 
    {
      _db = db;
    }

    public ActionResult Create(int id)
    {
      Stylist stylistOfClient = _db.Stylists.FirstOrDefault(stylist => stylist.Id == id);
      Console.WriteLine("stylists id = "+ stylistOfClient.Id);
      ViewBag.Stylist = stylistOfClient;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      Console.WriteLine("clients id = "+ client.Id);
      _db.SaveChanges();
      return RedirectToAction("Details", "Stylist", new {id = client.StylistId});
    }
  }
}