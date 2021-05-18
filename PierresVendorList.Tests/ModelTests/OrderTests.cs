using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorList.Models;

using System;

namespace PierresVendorList.Tests
{
  public class OrderTests
  {
    // {
    // [TestClass]
    // public class OrderTests : IDisposable
    // {

    //   public void Dispose()
    //   {
    //     Order.ClearAll();
    //   }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_newOrder()
    {
      Order newOrder = new Order("Sally's Cupcakes", "2/29/2021", "example title", "27 loaves of Rustic bread", 123854, 48);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    //   [TestMethod]
    //   public void GetDescription_ReturnsDescription_String()
    //   {
    //     //Arrange
    //     string description = "Walk the dog.";

    //     //Act
    //     Item newItem = new Item(description);
    //     string result = newItem.Description;

    //     //Assert
    //     Assert.AreEqual(description, result);
    //   }

    //   [TestMethod]
    //   public void SetDescription_SetDescription_String()
    //   {
    //     //Arrange
    //     string description = "Walk the dog.";
    //     Item newItem = new Item(description);

    //     //Act
    //     string updatedDescription = "Do the dishes";
    //     newItem.Description = updatedDescription;
    //     string result = newItem.Description;

    //     //Assert
    //     Assert.AreEqual(updatedDescription, result);
    //   }

    //   [TestMethod]
    //   public void GetAll_ReturnsEmptyList_ItemList()
    //   {
    //     // Arrange
    //     List<Item> newList = new List<Item> { };

    //     // Act
    //     List<Item> result = Item.GetAll();

    //     // Assert
    //     CollectionAssert.AreEqual(newList, result);
    //   }

    //   [TestMethod]
    //   public void GetAll_ReturnsItems_ItemList()
    //   {
    //     //Arrange
    //     string description01 = "Walk the dog";
    //     string description02 = "Wash the dishes";
    //     Item newItem1 = new Item(description01);
    //     Item newItem2 = new Item(description02);
    //     List<Item> newList = new List<Item> { newItem1, newItem2 };

    //     //Act
    //     List<Item> result = Item.GetAll();

    //     //Assert
    //     CollectionAssert.AreEqual(newList, result);
    //   }
  }
}