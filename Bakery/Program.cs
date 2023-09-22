using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("**~**~**~**~**~**~**~**~**~**~**~**~**~***");
      Console.WriteLine("*       Welcome to Pierre's Bakery       *");
      Console.WriteLine("*                                        *");
      Console.WriteLine("*       *---> Bread Prices <---*         *");
      Console.WriteLine("*                                        *");
      Console.WriteLine("*   Single loaf $5 | Buy 2, get 1 free!  *");
      Console.WriteLine("*                                        *");
      Console.WriteLine("*      *---> Pastry Prices <---*         *");
      Console.WriteLine("*                                        *");
      Console.WriteLine("* Single pastry $2 | Buy 3, get 1 free!  *");
      Console.WriteLine("*                                        *");
      Console.WriteLine("**~**~**~**~**~**~**~**~**~**~**~**~**~***");
      Console.WriteLine(" ");
      Console.WriteLine("Please enter the amount of the bread you'd like to buy:");
      Console.WriteLine(" ");
      Console.WriteLine("If you don't want any bread, simply enter 0.");
      Console.WriteLine(" ");
      string orderForBread = Console.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine($"You have {orderForBread} bread in your cart.");
      Console.WriteLine("--------------------------------------------------------");
      Console.WriteLine(" ");
      Console.WriteLine("Please enter the amount of the pastry you'd like to buy:");
      Console.WriteLine(" ");
      Console.WriteLine("If you don't want any pastry, simply enter 0.");
      Console.WriteLine(" ");
      string orderForPastry = Console.ReadLine();
      Console.WriteLine(" ");
      Console.WriteLine($"You have {orderForPastry} pastry in your cart.");
      Console.WriteLine("--------------------------------------------------------");
      Console.WriteLine(" ");
      Console.WriteLine("Creating your order, please wait...");
      Console.WriteLine(" ");
      System.Threading.Thread.Sleep(3000);

      try
      {
        Bread newBread = new Bread();
        Pastry newPastry = new Pastry();

        int convertedBreadOrder = int.Parse(orderForBread);
        int convertedPastryOrder = int.Parse(orderForPastry);

        newBread.NewOrder(convertedBreadOrder);
        int costForBreadOrder = newBread.CalcCost("bread");

        newPastry.NewOrder(convertedPastryOrder);
        int costForPastryOrder = newPastry.CalcCost("pastry");

        int totalCost = costForBreadOrder + costForPastryOrder;
        Console.WriteLine($"Your total is ${totalCost} for {orderForBread} bread and {orderForPastry} pastry.");
        Console.WriteLine(" ");
        Console.WriteLine("Thank you for shopping with us, have a good day!");
      }
      catch
      {
        Console.WriteLine("Something went wrong.");
      }
    }
  }
}