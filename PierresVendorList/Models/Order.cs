using System.Collections.Generic;
using System;
namespace PierresVendorList.Models
{
  public class Order
  {

    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Total { get; set; }
    public int InvoiceNumber { get; set; }
    public int vendorId { get; set; }
    private static List<Order> _instances = new List<Order> { };



    public Order(int Id, string date, string title, string description, int total)
    {

      Date = date;
      Title = title;
      Description = description;
      Total = total;
      _instances.Add(this);
      InvoiceNumber = _instances.Count;
      vendorId = Id;



    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int InvoiceNumber)
    {
      return _instances[InvoiceNumber - 1];
    }

  }
}
