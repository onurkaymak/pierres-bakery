using Bakery.Models;
using System;

namespace Bakery.Models

{
  public class Register /// Class Inheritance Practice, it allowed me to DRY my code up so much!
  {
    public int PriceOfSingleItem { get; set; }
    public int OrderAmount { get; set; }


    // With class inheritance, now we're able to use single NewOrder method and OrderAmount field for two different classes,
    //It allows us to set order amount for pastry and bread classes. It also holds the OrderAmount field in parent class but define for
    //both Bread and Pastry classes. 
    public void NewOrder(int amount)
    {
      OrderAmount = amount;
    }

    // With class inheritance, now we're able to use single CalcCost method.
    //It allows us to calculate cost of the bread or pastry orders from one single method call. 
    public int CalcCost(string type)
    {
      int discount = 0;
      if (type == "bread")
      {
        discount = 3;
      }
      else
      {
        discount = 4;
      }

      int total = 0;
      int itemToPay = 0;

      for (int index = 0; index <= OrderAmount; index++)
      {
        if (index % discount != 0)
        {
          itemToPay += 1;
        }
        else
        {
          itemToPay += 0;
        }
      }
      total = itemToPay * PriceOfSingleItem;

      return total;
    }

  }
}