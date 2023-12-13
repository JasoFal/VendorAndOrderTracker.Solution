using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public double OrderPrice { get; }

    public Order(string title, string description, double price)
    {
      OrderTitle = title;
      OrderDescription = description;
      OrderPrice = price;
    }
  }
}