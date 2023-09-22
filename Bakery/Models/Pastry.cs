namespace Bakery.Models
{
  public class Pastry
  {
    public static int OrderAmount { get; set; }
    public static int NewOrder(int amount)
    {
      return OrderAmount = amount;
    }
  }
}