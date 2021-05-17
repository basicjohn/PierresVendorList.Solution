using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendorList.Models;
using System.Collections.Generic;
using System;

namespace PierresVendorList.Tests
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
      Vendor newVendor = new Vendor("Sally's Cupcakes", "Sally makes regular orders to fill her baking needs.");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Sally's Cupcakes";
      Vendor newVendor = new Vendor(name, "Sally makes regular orders to fill her baking needs.");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Sally's Cupcakes";
      Vendor newVendor = new Vendor(name, "Sally makes regular orders to fill her baking needs.");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    //   [TestMethod]
    //   public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    //   {
    //     // Arrange
    //     string name01 = "Work";
    //     string name02 = "School";
    //     Category newCategory1 = new Category(name01);
    //     Category newCategory2 = new Category(name02);
    //     List<Category> newList = new List<Category> { newCategory1, newCategory2 };

    //     // Act
    //     List<Category> result = Category.GetAll();

    //     // Assert
    //     CollectionAssert.AreEqual(newList, result);

    //   }
    //   [TestMethod]
    //   public void Find_ReturnsCorrectCategory_Category()
    //   {
    //     // Arrange
    //     string name01 = "Work";
    //     string name02 = "School";
    //     Category newCategory1 = new Category(name01);
    //     Category newCategory2 = new Category(name02);
    //     // Act
    //     Category result = Category.Find(2);
    //     // Assert
    //     Assert.AreEqual(newCategory2, result);
    //   }

    //   [TestMethod]
    //   public void AddItem_AssociatesItemWithCategory_ItemList()
    //   {
    //     // Arrange
    //     string description = "Walk the dog.";
    //     Item newItem = new Item(description);
    //     List<Item> newList = new List<Item> { newItem };
    //     string name = "Work";
    //     Category newCategory = new Category(name);
    //     newCategory.AddItem(newItem);

    //     // Act
    //     List<Item> result = newCategory.Items;

    //     // Assert
    //     CollectionAssert.AreEqual(newList, result);
    //   }
  }
}