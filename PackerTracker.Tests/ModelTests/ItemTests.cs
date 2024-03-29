using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{

  [TestClass]
  public class ItemTests : IDisposable
  {
      public void Dispose()
      {
      Item.ClearAll();
      }
  
  

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

    [TestMethod]
  public void SetBool_SetItemBoolValue_Bool()
  {
    bool packed = false;
    Item newItem = new Item("hat", packed);
    bool updatedBool = true;
    newItem.Packed = updatedBool;
    bool result = newItem.Packed;
    Assert.AreEqual(updatedBool, result);
  }
   [TestMethod]
  public void GetAll_ReturnsEmptyList_ItemList()
  {
    List<Item> newList = new List<Item> { };
    List<Item> result = Item.GetAll();
    CollectionAssert.AreEqual(newList, result);
  }

  [TestMethod]
  public void ClearAll_DeletesAllItemsInList_Void()
  {
    Item newItem = new Item("hat", false);
    List<Item> expected = new List<Item> { };
    Item.ClearAll();
    CollectionAssert.AreEqual(expected, Item.GetAll());
  }

  [TestMethod]
  public void GetAll_ReturnsItemsInList_ItemList()
  {
      Item newItem1 = new Item("hat", false);
      Item newItem2 = new Item("socks", false);
      List<Item> newList = new List<Item> {newItem1, newItem2};
      List<Item> result = Item.GetAll();
      CollectionAssert.AreEqual(newList, result);
  }
   
  [TestMethod]
  public void GetId_ItemsIsntantiateWithAnIdAndGetterReturns_Int()
  {
    Item newItem = new Item("sunglasses", true);
    int result = newItem.Id;
    Assert.AreEqual(1, result);
  }
  [TestMethod]
  public void Find_ReturnsCorrectItem_Item()
  {
  Item newItem1 = new Item("sunglasses", true);
  Item newItem2 = new Item("socks", false);
  Item result = Item.Find(2);
  Assert.AreEqual(newItem2, result);
  }

  [TestMethod]
  public void Switch_SwitchValueOfBool_Bool()
  {
    Item newItem = new Item("socks", false);
    newItem.Switch();
    Assert.IsTrue(newItem.Packed);
  }
  }
}

