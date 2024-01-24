using System.Collections.Generic;
// using PackerTracker.Models;
// using System;

namespace PackerTracker.Models
{
  public class Item 
  {
  public Dictionary<string, bool> UserItem { get; set;}
  private static List<Item> _instances = new List<Item> { };
  public Item(Dictionary<string, bool> userItem)
  {
    UserItem = userItem;
    _instances.Add(this);
  }
  public static List<Item> GetAll()
  {
    return _instances;
  }
  public static void ClearAll()
  {
    _instances.Clear();
  }
}
}
