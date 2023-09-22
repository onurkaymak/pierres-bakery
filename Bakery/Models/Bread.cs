namespace Bakery.Models
{
  public class Bread
  {
    public static int PriceOfSingleLoaf { get; set; } = 5;
    public static int OrderAmount { get; set; }
    public static int NewOrder(int amount)
    {
      return OrderAmount = amount;
    }
  }
}