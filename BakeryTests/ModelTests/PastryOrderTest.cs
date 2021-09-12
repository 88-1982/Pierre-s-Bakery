using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreatesInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetOrderedPastries_ReturnsPastriesOrdered_Int()
    {
      int orderedPastries = 2;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      int result = newPastryOrder.OrderedPastries;
      Assert.AreEqual(orderedPastries, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForTwoPastries_Int()
    {
      int orderedPastries = 2;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForThreePastries_Int()
    {
      int orderedPastries = 3;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForFourPastries_Int()
    {
      int orderedPastries = 4;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForFivePastries_Int()
    {
      int orderedPastries = 5;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForSixPastries_Int()
    {
      int orderedPastries = 6;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForSevenPastries_Int()
    {
      int orderedPastries = 7;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForTwentyThreePastries_Int()
    {
      int orderedPastries = 23;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(39, result);
    }
  }
}