// using Microsoft.AspNetCore.Mvc;
// using PackerTracker.Models;
// using System.Collections.Generic;

// namespace PackerTracker.Controllers
// {
//   public class ItemsController : Controller
//   {
//     [HttpGet("/items")]
//     public ActionResult Index()
//     {
//       List<Item> allItems = Item.GetAll();
//       return View(allItems);
//     }

//     [HttpGet("/items/new")]
//     public ActionResult New()
//     {
//     return View();
//     }
    
//     [HttpPost("/items")]
//     public ActionResult Create(Dictionary<string, bool> userItem )
//     {
//       // Dictionary <string, bool> newDictionary = new Dictionary <string, bool> {{UserItem, false}};
//       Item myItem = new Item(userItem);
//       return RedirectToAction("Index");
//     }
    
//     [HttpPost("/items/delete")]
//     public ActionResult DeleteAll()
//     {
//       Item.ClearAll();
//       return View();
//     }

//   }
// }