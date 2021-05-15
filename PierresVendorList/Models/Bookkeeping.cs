using System.Collections.Generic;

namespace PierresVendorList.Models
{
  public class Bookkeeping
  {
    private static List<Bookkeeping> _vendors = new List<Bookkeeping> { };

    public Bookkeeping(string description)
    {
      _vendors.Add(this);
      Id = _vendors.Count;
    }

    public static List<Bookkeeping> GetAll()
    {
      return _vendors;
    }

    public static void ClearAll()
    {
      _vendors.Clear();
    }
    public static Bookkeeping Find(int searchId)
    {
      return _vendors[searchId - 1];
    }
  }
}
