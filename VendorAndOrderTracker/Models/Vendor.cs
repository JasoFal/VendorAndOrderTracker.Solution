using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }

    public Vendor(string name, string description)
    {
      VendorName = name;
      VendorDescription = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}