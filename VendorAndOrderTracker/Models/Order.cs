using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; }
    public string OrderDescription { get; set; }

    public Order(string title, string description)
    {
      OrderTitle = title;
      OrderDescription = description;
    }
  }
}