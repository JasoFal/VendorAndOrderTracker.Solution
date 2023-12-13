using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public double OrderPrice { get; set; }
    public string OrderDate { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description, double price, string date)
    {
      OrderTitle = title;
      OrderDescription = description;
      OrderPrice = price;
      OrderDate = date;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}