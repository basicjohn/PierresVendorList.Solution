using System.Collections.Generic;
using System;
namespace PierresVendorList.Models
{
  public class Order
  {

    public string VendorName { get; set; }
    public string Title { get; }
    public string Description { get; }
    public string Date { get; }
    public int Total { get; }
    public int InvoiceNumber { get; }


    public Order(string vendorName, string date, string title, string description, int invoiceNumber, int total)
    {
      VendorName = vendorName;
      Date = date;
      Title = title;
      Description = description;
      Total = total;
      InvoiceNumber = invoiceNumber;
    }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

  }
}
