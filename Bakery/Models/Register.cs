using Bakery.Models;

namespace Bakery.Models

{
  public class Register

  {
    public static int TotalCost { get; set; }

    public static void NewOrder(int amount, string type)
    {
      if (type == "bread")
      {
        Bread.OrderAmount = amount;
      }
      else
      {
        Pastry.OrderAmount = amount;
      }
    }
    public static void CaclTotalCost(int bakeryCost, int pastryCost)
    {
      TotalCost = bakeryCost + pastryCost;
    }
  }
}