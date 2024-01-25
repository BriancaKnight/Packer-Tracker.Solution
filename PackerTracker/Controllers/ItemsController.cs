using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/categories/{categoryId}/items/new")]
    public ActionResult New(int categoryId)
    {
       Category category = Category.Find(categoryId);
       return View(category);
    }
    
    [HttpGet("/categories/{categoryId}/items/{itemId}")]
    public ActionResult show(int categoryId, int itemId)
    {
      Item item = Item.Find(itemId);
      Category category = Category.Find(categoryId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("item", item);
      model.Add("category", category);
      return View(model);
    }

    [HttpPost("/categories/{categoryId}/items/{itemId}/switch")]
      public ActionResult SwitchPacked(int categoryId, int itemId)
      {
      Item item = Item.Find(itemId);
    
      item.Switch();
      
      return RedirectToAction("Show", new { categoryId, itemId });
      }
  }
}