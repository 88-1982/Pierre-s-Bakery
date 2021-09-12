namespace Bakery.Models
{
  public class BreadOrder
  {
    public int OrderedBread { get; set; }
    public int BreadPrice { get; set; }
    public BreadOrder(int breadOrder)
    {
      OrderedBread = breadOrder;
      BreadPrice = OrderedBread * 5;
    }

    public void SetBreadPrice()
    {
      if (OrderedBread > 2)
      {
        BreadPrice -= (OrderedBread / 3) * 5;
      }
    }
  }
}