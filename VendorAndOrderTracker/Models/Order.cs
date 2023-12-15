using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public double OrderPrice { get; set; }
    public int OrderDueDay { get; set; }
    public int OrderDueMonth { get; set; }
    public int OrderDueYear { get; set; }
    public string OrderDueDate { get; set; }
    public int Id { get; } 
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description, double price, int day, int month, int year)
    {
      OrderTitle = title;
      OrderDescription = description;
      OrderPrice = price;
      OrderDueMonth = month;
      OrderDueDay = day;
      OrderDueYear = year;
      OrderDueDate = OrderDueMonth.ToString() + "/" + OrderDueDay.ToString() + "/" + OrderDueYear.ToString();
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}