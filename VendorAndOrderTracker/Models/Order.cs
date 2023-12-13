using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderDescription { get; }

    public Order(string description)
    {
      OrderDescription = description;
    }
  }
}