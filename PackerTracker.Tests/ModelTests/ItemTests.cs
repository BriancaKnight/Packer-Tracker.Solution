using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.TestTools
{
[TestClass]
public class ItemTests
{
Dictionary<string, bool> propDictionary = new Dictionary<string, bool>() {{"hat", false}, {"sunglasses", true}};

 [TestMethod]

  public void ItemConstructor_CreateInstanceOfItem_Item()
  {
    Item newItem = new Item(propDictionary);
    Assert.AreEqual(typeof(Item), newItem.GetType());
  }

  [TestMethod]
  public void GetUserItem_ReturnUserItemValue_Dictionary()
  {
    Item newItem = new Item(propDictionary);
    Dictionary<string, bool> result = newItem.UserItem;
    CollectionAssert.AreEqual(propDictionary, result);
  }

  [TestMethod]
  public void SetUserItem_SetItemValue_Dictionary()
  {
    Item newItem = new Item(propDictionary);
    Dictionary<string, bool> updatedUserItem = new Dictionary<string, bool>() {{"hat", true}, {"sunglasses", false}};
    newItem.UserItem = updatedUserItem;
    Dictionary<string, bool> result = newItem.UserItem;
    CollectionAssert.AreEqual(updatedUserItem, result);
  }
}
}
