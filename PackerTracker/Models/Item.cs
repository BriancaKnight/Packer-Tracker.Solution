using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
      public int ItemId { get; set; }
      public string Name {get; set;}
      public bool Packed {get; set;}
      public int CategoryId { get; set; }
      public Category Category { get; set; }
  }
}
