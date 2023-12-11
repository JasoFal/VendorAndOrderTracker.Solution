namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
    }
  }
}