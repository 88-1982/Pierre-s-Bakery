namespace Bakery.Models
{
  public class PastryOrder
  {
    public int OrderedPastries { get; set; }
    public int BasePrice { get; set; }
    public int PastriesPrice { get; set; }
  
    public PastryOrder(int orderedPastries)
    {
      OrderedPastries = orderedPastries;
      PastriesPrice = 2 * OrderedPastries;
    }

    public void SetPastriesPrice()
    {
      if (OrderedPastries > 2)
      {
        PastriesPrice -= OrderedPastries / 3;
      }
    }
  }
}