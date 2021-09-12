using System;
using Bakery.Models;

namespace Bakery
{
  public class program
{
public static void main()
{
  Console.WriteLine("----------Pierre's----------");
      Console.WriteLine("Welcome to Pierre's Bakery, we've the finest selection of bread and pastries.");
      Console.WriteLine("Bread: $5/each. We're also running a sale for buy 2 get 1 free!");
      Console.WriteLine("Pastries: $2/each, or 3 for $5");
      Console.WriteLine("----------------------------");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadLoaves = Console.ReadLine();
      int orderedBread;
      int total = 0;
      bool isBreadWhole = int.TryParse(breadLoaves, out orderedBread);
      if (isBreadWhole && orderedBread >= 0)
      {
        BreadOrder newBreadOrder = new BreadOrder(orderedBread);
        newBreadOrder.SetBreadPrice();
        total += newBreadOrder.OrderedBread;
      }
}
}
}


  
  