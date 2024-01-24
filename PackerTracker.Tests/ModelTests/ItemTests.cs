using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.TestTools
{
[TestClass]
public class ItemTests
{
  
 [TestMethod]

  public void ItemConstructor_CreateInstanceOfItem_Item()
  {
    Item newItem = new Item("hat");
    Assert.AreEqual(typeof(Item), newItem.GetType());
  }
  [TestMethod]
  public void GetUserItem_ReturnUserItemValue_String()
  {
    string userItem = "hat";
    Item newItem = new Item(userItem);
    string result = newItem.UserItem;
    Assert.AreEqual(userItem, result);
  }
}
}
