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
  }
}
