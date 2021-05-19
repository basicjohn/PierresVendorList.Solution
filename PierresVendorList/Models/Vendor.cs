using System.Collections.Generic;

namespace PierresVendorList.Models
{
  public class Vendor
  {
    private static Dictionary<int, Vendor> _vendors = new Dictionary<int, Vendor> { };
    public string Name { get; set; }
    public int Id { get; }

    public string Description { get; }

    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string description)
    {
      Name = vendorName;
      Description = description;
      _vendors.Add(this);
      Id = _vendors.Count;
      Orders = new List<Order> { };
    }
    public static void ClearAll()
    {
      _vendors.Clear();
    }
    public static Dictionary<int, Vendor> GetAll()
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