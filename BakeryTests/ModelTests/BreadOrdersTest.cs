using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrdered_Int()
    {
      int orderedBread = 2;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      int result = newBreadOrder.OrderedBread;
      Assert.AreEqual(orderedBread, result);
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsOrderPrice_Int()
    {
      int orderedBread = 0;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      int result = newBreadOrder.BreadPrice;
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void SetBreadPrice_ReturnsPriceMultipliedByBread_Int()
    {
      int orderedBread = 2;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      newBreadOrder.SetBreadPrice();
      int result = newBreadOrder.BreadPrice;
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void SetBreadPrice_ReturnsPriceForOneFreeLoaf_Int()
    {
      int orderedBread = 3;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      newBreadOrder.SetBreadPrice();
      int result = newBreadOrder.BreadPrice;
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void SetBreadPrice_ReturnsPriceForFiveLoavesPurchased_Int()
    {
      int orderedBread = 5;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      newBreadOrder.SetBreadPrice();
      int result = newBreadOrder.BreadPrice;
      Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void SetBreadPrice_ReturnsPriceForSevenLoavesPurchased_Int()
    {
      int orderedBread = 7;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      newBreadOrder.SetBreadPrice();
      int result = newBreadOrder.BreadPrice;
      Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void SetBreadPrice_ReturnsEvenNumberedPrices_Int()
    {
      int orderedBread = 4;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      newBreadOrder.SetBreadPrice();
      int result = newBreadOrder.BreadPrice;
      Assert.AreEqual(15, result);
    }
  }
}
