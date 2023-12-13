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
      Order newOrder = new Order("Test", "thing", 3.14, "05/27/99");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Order Description", 2.14, "05/27/99");
      string result = newOrder.OrderTitle;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Order Description", 3.14, "05/27/99");
      string updatedOrderTitle = "Testier Order";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;
      Assert.AreEqual(updatedOrderTitle, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order("thing", description, 3.14, "05/27/99");
      string result = newOrder.OrderDescription;
      Assert.AreEqual(result, description);
    }

    [TestMethod]
    public void SetOrderDescription_SetOrderDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order("thing", description, 4.12, "05/27/99");
      string updatedOrderDescription = "Steamed Hams";
      newOrder.OrderDescription = updatedOrderDescription;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(updatedOrderDescription, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Double()
    {
      double price = 4.74;
      Order newOrder = new Order("Test", "Order", price, "05/27/99");
      double result = newOrder.OrderPrice;
      Assert.AreEqual(result, price);
    }

    [TestMethod]
    public void SetOrderPrice_SetOrderPrice_Double()
    {
      double price = 3.12;
      Order newOrder = new Order("Test", "Double", price, "05/27/99");
      double updatedOrderPrice = 1068.43;
      newOrder.OrderPrice = updatedOrderPrice;
      double result = newOrder.OrderPrice;
      Assert.AreEqual(updatedOrderPrice, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnOrderDate_String()
    {
      string date = "05/27/99";
      Order newOrder = new Order("Test", "That", 8, date);
      string result = newOrder.OrderDate;
      Assert.AreEqual(result, date);
    }

    [TestMethod]
    public void SetOrderDate_SetOrderDate_String()
    {
      string date = "11/6/83";
      Order newOrder = new Order("Test", "Double", 4.21, date);
      string updatedOrderDate = "8/31/95";
      newOrder.OrderDate = updatedOrderDate;
      string result = newOrder.OrderDate;
      Assert.AreEqual(updatedOrderDate, result);
    }
  }
}  