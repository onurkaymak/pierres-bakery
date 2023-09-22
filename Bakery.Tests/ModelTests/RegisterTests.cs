using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class RegisterTests
  {
    [TestMethod]
    public void TakeOrder()
    {
      Register.NewOrder(2, "bread");
      int order = 2;
      int result = Bread.OrderAmount;
      Assert.AreEqual(order, result);
    }
  }
}