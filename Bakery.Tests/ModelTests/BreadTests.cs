using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void NewOrderMethod_SetsOrderAmount_OrderAmount()
    {
      int orderAmount = 2;
      int result = Bread.NewOrder(orderAmount);
      Assert.AreEqual(orderAmount, result);
    }
  }
}