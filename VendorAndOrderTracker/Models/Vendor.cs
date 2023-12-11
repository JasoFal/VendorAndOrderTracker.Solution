namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }

    public Vendor(string name, string description)
    {
      VendorName = name;
      VendorDescription = description;
      Id = _instances.Count;
    }
  }
}