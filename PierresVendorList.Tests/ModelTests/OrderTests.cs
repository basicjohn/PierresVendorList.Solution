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
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_newOrder()
    {
      Vendor newVendor = new Vendor("Sally's Cupcakes", "Sally makes regular orders to fill her baking needs.");
      Order newOrder = new Order(newVendor.vendorId, "2/29/2021", "example title", "27 loaves of Rustic bread", 48);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string orderTitle = "example title";
      Vendor newVendor = new Vendor("Sally's Cupcakes", "Sally makes regular orders to fill her baking needs.");
      Order newOrder = new Order(newVendor.vendorId, "2/29/2021", orderTitle, "27 loaves of Rustic bread", 48);
      string result = newOrder.Title;
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string orderTitle = "example title";
      Vendor newVendor = new Vendor("Sally's Cupcakes", "Sally makes regular orders to fill her baking needs.");
      Order newOrder = new Order(newVendor.vendorId, "2/29/2021", orderTitle, "27 loaves of Rustic bread", 48);
      string updatedOrderTitle = "new example title";
      newOrder.Title = updatedOrderTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedOrderTitle, result);
    }
    [TestMethod]
    public void GetInvoiceId_ReturnsInvoiceId_Int()
    {
      int InvoiceNumber = 1;
      Vendor newVendor = new Vendor("Sally's Cupcakes", "Sally makes regular orders to fill her baking needs.");
      Order newOrder = new Order(newVendor.vendorId, "2/29/2021", "example title", "27 loaves of Rustic bread", 48);
      int result = newOrder.InvoiceNumber;
      Assert.AreEqual(InvoiceNumber, result);
    }
  }
}