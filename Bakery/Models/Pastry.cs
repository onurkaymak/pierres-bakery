namespace Bakery.Models
{
  public class Pastry
  {
    public static int PriceOfSinglePastry { get; set; } = 2;
    public static int OrderAmount { get; set; }
    public static int NewOrder(int amount)
    {
      return OrderAmount = amount;
    }

    public static int CalcCost()
    {
      return OrderAmount * PriceOfSinglePastry;
    }
  }
}