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
      Bread.NewOrder(2);
      int order = 2;
      int result = Bread.OrderAmount;
      Assert.AreEqual(order, result);
    }

    // [TestMethod]
    // public void NewOrderMethod_SetsAmountForPastry_Void()
    // {
    //   Register.NewOrder(3, "pastry");
    //   int order = 3;
    //   int result = Pastry.OrderAmount;
    //   Assert.AreEqual(order, result);
    // }
  }
}