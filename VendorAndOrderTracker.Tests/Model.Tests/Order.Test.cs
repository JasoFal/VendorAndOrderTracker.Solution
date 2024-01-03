using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test", "thing", 3.14, 10, 10, 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Order Description", 2.14, 10, 10, 10);
      string result = newOrder.OrderTitle;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Order Description", 3.14, 10, 10, 10);
      string updatedOrderTitle = "Testier Order";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;
      Assert.AreEqual(updatedOrderTitle, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order("thing", description, 3.14, 10, 10, 10);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(result, description);
    }

    [TestMethod]
    public void SetOrderDescription_SetOrderDescription_String()
    {
      string description = "Test Order";
      Order newOrder = new Order("thing", description, 4.12, 10, 10, 10);
      string updatedOrderDescription = "Steamed Hams";
      newOrder.OrderDescription = updatedOrderDescription;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(updatedOrderDescription, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Double()
    {
      double price = 4.74;
      Order newOrder = new Order("Test", "Order", price, 10, 10, 10);
      double result = newOrder.OrderPrice;
      Assert.AreEqual(result, price);
    }

    [TestMethod]
    public void SetOrderPrice_SetOrderPrice_Double()
    {
      double price = 3.12;
      Order newOrder = new Order("Test", "Double", price, 10, 10, 10);
      double updatedOrderPrice = 1068.43;
      newOrder.OrderPrice = updatedOrderPrice;
      double result = newOrder.OrderPrice;
      Assert.AreEqual(updatedOrderPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      Order newOrder01 = new Order("Test", "This", 15, 10, 10, 10);
      Order newOrder02 = new Order("Thing", "thing", 75146, 10, 10, 10);
      List<Order> newList = new List<Order> { newOrder01, newOrder02 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      Order newOrder = new Order("test", "test", 1.11, 10, 10, 10);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnCorrectOrder_Order()
    {
      Order newOrder01 = new Order("Test", "Test", 15, 10, 10, 10);
      Order newOrder02 = new Order("Test", "Test", 16, 10, 10, 10);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder02, result);
    }

    [TestMethod]
    public void GetOrderDueDate_ReturnOrderDueDate_String()
    {
      int month = 8;
      int day = 27;
      int year = 2010;
      Order newOrder = new Order("test", "test", 1.11, month, day, year);
      string dueDate = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
      string result = newOrder.OrderDueDate;
      Assert.AreEqual(result, dueDate);
    }

    [TestMethod]
    public void SetOrderDueDate_SetOrderDueDate_String()
    {
      int month = 8;
      int day = 27;
      int year = 2010;
      Order newOrder = new Order("test", "test", 1.11, month, day, year);
      string newDueDay = "05/27/1999";
      newOrder.OrderDueDate = newDueDay;
      string brandNewDueDate = newOrder.OrderDueDate;
      Assert.AreEqual(newDueDay, brandNewDueDate);
    }

    [TestMethod]
    public void ClearAll_ClearsAll_Instances_OrderList()
    {
      Order newOrder01 = new Order("Test", "Test", 15, 10, 10, 10);
      Order newOrder02 = new Order("Test", "Test", 16, 10, 10, 10);
      List<Order> result = new List<Order> { };
      Order.ClearAll();
      CollectionAssert.AreEqual(Order.GetAll(), result);
    }
  }
}