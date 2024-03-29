using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    private readonly PackerTrackerContext _db;

    public ItemsController(PackerTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    
    [HttpPost]
    public ActionResult Create(Item item)
    {
      _db.Items.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
{
    Item thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    return View(thisItem);
}
  }
}
