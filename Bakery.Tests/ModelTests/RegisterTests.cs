using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class RegisterTests
  {
    [TestMethod]
    public void NewOrderMethod_SetsAmountForBread_Void()
    {
      Bread newBread = new Bread();
      newBread.NewOrder(2);
      int order = 2;
      int result = newBread.OrderAmount;
      Assert.AreEqual(order, result);
    }

    [TestMethod]
    public void NewOrderMethod_SetsAmountForPastry_Void()
    {
      Pastry newPastry = new Pastry();

      newPastry.NewOrder(3);
      int order = 3;
      int result = newPastry.OrderAmount;
      Assert.AreEqual(order, result);
    }
  }
}