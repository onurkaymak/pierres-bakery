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
      int total = 0;
      int itemToPay = 0;

      for (int index = 0; index <= OrderAmount; index++)
      {
        if (index % 4 != 0)
        {
          itemToPay += 1;
        }
        else
        {
          itemToPay += 0;
        }
      }
      total = itemToPay * PriceOfSinglePastry;

      return total;
    }

    public static void ClearAll()
    {
      OrderAmount = 0;
    }
  }
}