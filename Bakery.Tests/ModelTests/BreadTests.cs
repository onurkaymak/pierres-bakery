using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

    // [TestMethod]
    // public void NewOrderMethod_SetsOrderAmount_OrderAmount()
    // {
    //   int orderAmount = 2;
    //   int result = Bread.NewOrder(orderAmount);
    //   Assert.AreEqual(orderAmount, result);
    // }

    // [TestMethod]
    // public void CalcCostMethod_CalculatesCostForSingleLoaf_Cost()
    // {
    //   int cost = 5;
    //   int orderAmount = Bread.NewOrder(1);
    //   int result = Bread.CalcCost();
    //   Assert.AreEqual(cost, result);
    // }

    // [TestMethod]
    // public void CalcCostMethod_CalculatesCostForOrder_Cost()
    // {
    //   int newOrder = Bread.NewOrder(2);
    //   int cost = 10;
    //   int result = Bread.CalcCost();
    //   Assert.AreEqual(cost, result);
    // }

    // [TestMethod]
    // public void CalcCostMethod_CalculatesCostWithDiscount_Cost()
    // {
    //   int cost = 10;
    //   int orderAmount = Bread.NewOrder(3);
    //   int result = Bread.CalcCost();
    //   Assert.AreEqual(cost, result);
    // }
  }
}