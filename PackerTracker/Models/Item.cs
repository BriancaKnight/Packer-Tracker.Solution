using System.Collections.Generic;
// using PackerTracker.Models;
// using System;

namespace PackerTracker.Models
{
  public class Item 
  {
  public Dictionary<string, bool> UserItem { get; set;}
  
  public Item(Dictionary<string, bool> userItem)
  {
    UserItem = userItem;
  }
}
}
