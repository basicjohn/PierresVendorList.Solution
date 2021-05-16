using System.Collections.Generic;
using System;
namespace PierresVendorList.Models
{
  public class Order
  {

    public string VendorName { get; set; }
    public string Title { get; }
    public string Description { get; }
    public DateTime Date { get; }
    public int Total { get; }
    public int InvoiceNumber { get; }


    public Order(string vendorName, DateTime date, string title, string description, int invoiceNumber, int total)
    {
      VendorName = vendorName;
      Date = date;
      Title = title;
      Description = description;
      Total = total;
      InvoiceNumber = invoiceNumber;
    }


  }
}
