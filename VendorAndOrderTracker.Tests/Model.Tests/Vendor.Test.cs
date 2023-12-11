using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  
  }
}