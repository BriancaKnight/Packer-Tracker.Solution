using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.TestTools{

  [TestClass]
  public class PackerTrackerTests
  {

    [TestMethod]
    public void ItemConstructor_CreateInstanceOfItem_Item()
  {
    Item newItem = new Item("hat", false);
    Assert.AreEqual(typeof(Item), newItem.GetType());
  }
   [TestMethod]
   public void GetName_ReturnNameValue_String()
  {
     string name = "hat";
     Item newItem = new Item(name, false);
     string result = newItem.Name;
     Assert.AreEqual(name, result);
  }

    [TestMethod]
  public void SetNameItem_SetItemNameValue_String()
  {
    string name = "hat";
    Item newItem = new Item(name, false);
    string updatedName = "sunglasses";
    newItem.Name = updatedName;
    string result = newItem.Name;
    Assert.AreEqual(updatedName, result);
  }
  
  [TestMethod]
  public void GetItemBool_ReturnItemBoolValue_Bool()
  {
    bool packed = false;
    Item newItem = new Item("hat", packed);
    bool result = newItem.Packed;
    Assert.AreEqual(packed, result);
  }

  }
}

// namespace PackerTracker.TestTools
// {
// [TestClass]
// public class ItemTests : IDisposable
// {
// public void Dispose()
// {
//   Item.ClearAll();
// }

// Dictionary<string, bool> propDictionary = new Dictionary<string, bool>() {{"hat", false}, {"sunglasses", true}};

//  [TestMethod]
//   public void ItemConstructor_CreateInstanceOfItem_Item()
//   {
//     Item newItem = new Item(propDictionary);
//     Assert.AreEqual(typeof(Item), newItem.GetType());
//   }

//   [TestMethod]
//   public void GetUserItem_ReturnUserItemValue_Dictionary()
//   {
//     Item newItem = new Item(propDictionary);
//     Dictionary<string, bool> result = newItem.UserItem;
//     CollectionAssert.AreEqual(propDictionary, result);
//   }

//   [TestMethod]
//   public void SetUserItem_SetItemValue_Dictionary()
//   {
//     Item newItem = new Item(propDictionary);
//     Dictionary<string, bool> updatedUserItem = new Dictionary<string, bool>() {{"hat", true}, {"sunglasses", false}};
//     newItem.UserItem = updatedUserItem;
//     Dictionary<string, bool> result = newItem.UserItem;
//     CollectionAssert.AreEqual(updatedUserItem, result);
//   }
  
//   [TestMethod]
//   public void ClearAll_DeletesAllItemsInList_Void()
//   {
//     Item newItem = new Item(propDictionary);
//     List<Item> expected = new List<Item> { };
//     Item.ClearAll();
//     CollectionAssert.AreEqual(expected, Item.GetAll());
//   }

//   [TestMethod]
//   public void GetAll_ReturnsEmptyList_ItemList()
//   {
//     List<Item> newList = new List<Item> { };
//     List<Item> result = Item.GetAll();
//     CollectionAssert.AreEqual(newList, result);
//   }

//   [TestMethod]
//   public void GetAll_ReturnItems_ItemList()
//   {
//     Dictionary <string, bool> dictionary1 = new Dictionary<string, bool> {{"hat", false}, {"sunglasses", true}};
//     Dictionary <string, bool> dictionary2 = new Dictionary<string, bool> {{"sunscreen", true}, {"bathing suit", false}};
//     Item newItem1 = new Item(dictionary1);
//     Item newItem2 = new Item(dictionary2);
//     List<Item> newList = new List<Item> { newItem1, newItem2 };
//     List<Item> result = Item.GetAll();
//     CollectionAssert.AreEqual(newList, result);
//   }
//   [TestMethod]
//   public void GetId_ItemsIsntantiateWithAnIdAndGetterReturns_Int()
//   {
//     Dictionary <string, bool> dictionary = new Dictionary<string, bool> {{"hat", false}, {"sunglasses", true}};
//     Item newItem = new Item(dictionary);
//     int result = newItem.Id;
//     Assert.AreEqual(1, result);
//   }
  
//   [TestMethod]
//   public void Find_ReturnsCorrectItem_Item()
//   {
//     Dictionary <string, bool> dictionary1 = new Dictionary<string, bool> {{"hat", false}, {"sunglasses", true}};
//     Dictionary <string, bool> dictionary2 = new Dictionary<string, bool> {{"sunscreen", true}, {"bathing suit", false}};
//     Item newItem1 = new Item(dictionary1);
//     Item newItem2 = new Item(dictionary2);
//     Item result = Item.Find(2);
//     Assert.AreEqual(newItem2, result);
//   }
// }
// }


