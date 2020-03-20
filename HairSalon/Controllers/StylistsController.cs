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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist selectedStylist = _db.Stylists.FirstOrDefault(stylist => stylist.Id == id);
      selectedStylist.Clients = _db.Clients.Where(client => client.StylistId == selectedStylist.Id).ToList();
      return View(selectedStylist);
    }

    public ActionResult Delete(int id)
    {
      Stylist stylistToDelete = _db.Stylists.FirstOrDefault(stylist => stylist.Id == id);
      return View(stylistToDelete);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult ConfirmDelete(int id)
    {

      Stylist stylistToDelete = _db.Stylists.FirstOrDefault(stylist => stylist.Id == id);
      stylistToDelete.Clients = _db.Clients.Where(client => client.StylistId == stylistToDelete.Id).ToList();
      foreach (Client client in stylistToDelete.Clients)
      {
        _db.Clients.Remove(client);
      }
      _db.Stylists.Remove(stylistToDelete);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}