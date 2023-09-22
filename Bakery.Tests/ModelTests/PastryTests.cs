using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void NewOrderMethod_SetsOrderAmount_OrderAmount()
    {
      int orderAmount = 1;
      int result = Pastry.NewOrder(orderAmount);
      Assert.AreEqual(orderAmount, result);
    }

    [TestMethod]
    public void CalcCostMethod_CalculatesCostForSinglePastry_Cost()
    {
      int cost = 2;
      int orderAmount = Pastry.NewOrder(1);
      int result = Pastry.CalcCost();
      Assert.AreEqual(cost, result);
    }

    [TestMethod]
    public void CalcCostMethod_CalculatesCostWithDiscount_Cost()
    {
      int cost = 6;
      int orderAmount = Pastry.NewOrder(4);
      int result = Pastry.CalcCost();
      Assert.AreEqual(cost, result);
    }
  }
}