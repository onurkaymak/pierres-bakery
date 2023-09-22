using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {


    [TestMethod]
    public void NewOrderMethod_SetsOrderAmount_OrderAmount()
    {
      int orderAmount = 1;
      int result = Pastry.NewOrder(orderAmount);
      Assert.AreEqual(orderAmount, result);
    }

  }
}