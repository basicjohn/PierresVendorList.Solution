using System.Collections.Generic;

namespace PierresVendorList.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> { };
    public string Name { get; set; }
    public int vendorId { get; }

    public string Description { get; }

    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      vendorId = _vendors.Count;
      Orders = new List<Order> { };
      _vendors.Add(this);

    }
    public static void ClearAll()
    {
      _vendors.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendors;
    }
    public static Vendor Find(int searchId)
    {
      return _vendors[searchId - 1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}