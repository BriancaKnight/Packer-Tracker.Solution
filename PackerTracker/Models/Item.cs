using System.Collections.Generic;
// using PackerTracker.Models;
// using System;

namespace PackerTracker.Models
{
  public class Item 
  {
  public Dictionary<string, bool> UserItem { get; set;}
  private static List<Item> _instances = new List<Item> { };
   public int Id { get; }
  public Item(Dictionary<string, bool> userItem)
  {
    UserItem = userItem;
    _instances.Add(this);
    Id = _instances.Count;
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

    public static List<Item> GetAll()
  {
    return _instances;
  }
}
}
