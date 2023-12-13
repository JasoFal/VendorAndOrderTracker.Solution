using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test", "Test 2 Test Harder");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnVendorName_String()
    {
      string name = "Sal's Salami";
      Vendor newVendor = new Vendor(name, "Test");
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnVendorDescription_String()
    {
      string description = "Sal's Salami sells salami.";
      Vendor newVendor = new Vendor("Sal's Salami", description);
      string result = newVendor.VendorDescription;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("Test", "Test2");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("Test1", "Test2");
      Vendor newVendor2 = new Vendor("Test3", "Test4");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "NameTest1";
      string description01 = "DescriptionTest01";
      Vendor newVendor1 = new Vendor(name01, description01);
      string name02 = "NameTest02";
      string description02 = "DescriptionTest02";
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}