using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Models
{
  public class Item 
  {

  public string UserItem { get; }
  
  public Item(string userItem)
  {
    UserItem = userItem;
  }
}
}