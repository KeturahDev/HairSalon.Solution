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
      Stylist stylistOfClient = _db.Stylists.FirstOrDefault(stylist => stylist.Id == id); //correctly grabs it
      // Console.WriteLine("stylists id = "+ stylistOfClient.Id);
      ViewBag.Stylist = stylistOfClient; //correctly passes in this obj
      return View();
    }

    [HttpPost] //in the create form is where its getting jacked up
    public ActionResult Create(Client client)
    {
      //clients are being created with stylist id overwriting their auto incremented ids
      Console.WriteLine("clients id = "+ client.Id);
      Console.WriteLine("clients StylistId = "+ client.StylistId);

      _db.Clients.Add(client); //works fine
      _db.SaveChanges(); //yes
      return RedirectToAction("Details", "Stylist", new {id = client.StylistId}); //correctly directs to pg
    }
  }
}