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
      Order newOrder = new Order("Test", "thing", 3.14);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Order Description", 2.14);
      string result = newOrder.OrderTitle;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Order Description", 3.14);
      string updatedOrderTitle = "Testier Order";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;
      Assert.AreEqual(updatedOrderTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order("thing", description, 3.14);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(result, description);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order("thing", description, 4.12);
      string updatedOrderDescription = "Steamed Hams";
      newOrder.OrderDescription = updatedOrderDescription;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(updatedOrderDescription, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Float()
    {
      double price = 4.74;
      Order newOrder = new Order("Test", "Order", price);
      double result = newOrder.OrderPrice;
      Assert.AreEqual(result, price);
    }
  }
}  