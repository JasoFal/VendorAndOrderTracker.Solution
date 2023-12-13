using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order(description);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(result, description);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order(description);
      string updatedOrder = "Steamed Hams";
      newOrder.OrderDescription = updatedOrder;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(updatedOrder, result);
    }
  }
}  