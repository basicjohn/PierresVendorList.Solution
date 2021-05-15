using System.Collections.Generic;

namespace PierresVendorList.Models
{
  public class Order
  {

    public string VendorName { get; set; }
    public string Title { get; }
    public string Description { get; }
    public int Date { get; }
    public int Total { get; }
    public int InvoiceNumber { get; }

    private static List<Item> _instances = new List<Item> { };

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
