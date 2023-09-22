using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesFieldForAmount_Amount()
    {
      int orderAmount = 2;
      int result = Bread.NewOrder(orderAmount);
      Assert.AreEqual(orderAmount, result);
    }
  }
}