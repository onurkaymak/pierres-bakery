namespace Bakery.Models
{
  public class Pastry
  {
    public static int PriceOfSinglePastry { get; set; } = 2;
    public static int OrderAmount { get; set; }

    public static int CalcCost()
    {
      int total = 0;
      int loavesToPay = 0;

      for (int index = 0; index <= OrderAmount; index++)
      {
        if (index % 4 != 0)
        {
          loavesToPay += 1;
        }
        else
        {
          loavesToPay += 0;
        }
      }
      total = loavesToPay * PriceOfSinglePastry;

      return total;
    }

    public static void ClearAll()
    {
      OrderAmount = 0;
    }
  }
}