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

    public static int CalcCost()
    {
      int total = 0;
      int loavesToPay = 0;

      for (int index = 0; index <= OrderAmount; index++)
      {
        if (index % 3 != 0)
        {
          loavesToPay += 1;
        }
        else
        {
          loavesToPay += 0;
        }
      }
      total = loavesToPay * PriceOfSingleLoaf;

      return total;
    }

    public static void ClearAll()
    {
      OrderAmount = 0;
    }
  }
}