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
    Item newItem = new Item();
    Assert.AreEqual(typeof(Item), newItem.GetType());
  }
}
}
