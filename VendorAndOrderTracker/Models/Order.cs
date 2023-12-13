using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }

    public Order(string title, string description)
    {
      OrderTitle = title;
      OrderDescription = description;
    }
  }
}