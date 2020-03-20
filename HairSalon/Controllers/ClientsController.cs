using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
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

    [HttpPost] 
    public ActionResult Create(Client client)
    {
      Console.WriteLine("clients id = "+ client.ClientId);
      Console.WriteLine("clients StylistId = "+ client.StylistId);

      _db.Clients.Add(client);
      _db.SaveChanges(); 
      return RedirectToAction("Details", "Stylist", new {id = client.StylistId});
    }

    public ActionResult Details(int id)
    {
      Client clientToDisplay = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(clientToDisplay);
    }

    public ActionResult Edit(int id)
    {
      Client clientToDisplay = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(clientToDisplay);
    }
    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = client.ClientId});
    }
  }
}