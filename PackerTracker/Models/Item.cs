using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
      public string Name {get; set;}
      public bool Packed {get; set;}
      private static List<Item> _instances = new List<Item> { };
      public int Id { get; }
      
    public Item(string name, bool packed)
    {
      Name = name;
      Packed = packed;
      _instances.Add(this);
      Id = _instances.Count;
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



// using System.Collections.Generic;

// namespace PackerTracker.Models
// {
//   public class Item 
//   {
//   public Dictionary<string, bool> UserItem { get; set;}
//   private static List<Item> _instances = new List<Item> { };
//    public int Id { get; }
//   public Item(Dictionary<string, bool> userItem)
//   {
//     UserItem = userItem;
//     _instances.Add(this);
//     Id = _instances.Count;
//   }

//   public static void ClearAll()
//   {
//     _instances.Clear();
//   }

//     public static List<Item> GetAll()
//   {
//     return _instances;
//   }

//   public static Item Find(int searchId)
//   {
//     return _instances[searchId - 1];
//   }
// }
// }
