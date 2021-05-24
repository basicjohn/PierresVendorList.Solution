using System.Collections.Generic;
using System;
namespace PierresVendorList.Models
{
  public class Order
  {

    public string Title { get; }
    public string Description { get; }
    public string Date { get; }
    public int Total { get; }
    public int InvoiceNumber { get; }
    public int vendorId { get; set; }
    private static List<Order> _instances = new List<Order> { };



    public Order(int Id, string date, string title, string description, int invoiceNumber, int total)
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
