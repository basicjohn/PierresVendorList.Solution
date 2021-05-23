using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendorList.Models;
using System.Collections.Generic;
using System;

namespace PierresVendorList.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_newOrder()
    {
      Order newOrder = new Order("Sally's Cupcakes", "2/29/2021", "example title", "27 loaves of Rustic bread", 123854, 48);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Sally's Cupcakes";
      Order newOrder = new Order(vendorName, "2/29/2021", "example title", "27 loaves of Rustic bread", 123854, 48);
      string result = newOrder.VendorName;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string vendorName = "Sally's Cupcakes";
      Order newOrder = new Order(vendorName, "2/29/2021", "example title", "27 loaves of Rustic bread", 123854, 48);
      string updatedVendorName = "Patty's Cupcakes";
      newOrder.VendorName = updatedVendorName;
      string result = newOrder.VendorName;
      Assert.AreEqual(updatedVendorName, result);
    }
    [TestMethod]
    public void GetInvoiceId_ReturnsInvoiceId_Int()
    {
      int invoiceId = 123854;
      Order newOrder = new Order("Sally's Cupcakes", "2/29/2021", "example title", "27 loaves of Rustic bread", invoiceId, 48);
      int result = newOrder.InvoiceNumber;
      Assert.AreEqual(invoiceId, result);
    }
  }
}