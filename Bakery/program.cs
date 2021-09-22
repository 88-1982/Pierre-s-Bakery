using System;
using Bakery.Models;

namespace Bakery
{
  public class program
{
public static void Main()
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
      else
      {
        Console.WriteLine("Please add only an intgers");
        Main();  
      }
      Console.WriteLine("How many pastries would you like?");
      string pastryPieces = Console.ReadLine();
      int orderedPastries;
      bool arePastriesWhole = int.TryParse(pastryPieces, out orderedPastries);
      if (arePastriesWhole && orderedPastries >= 0)
    {
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
        newPastryOrder.SetPastriesPrice();
        total += newPastryOrder.PastriesPrice;
      }
      else
      {
        Console.WriteLine("Please add only an intgers");
        Main();
      }
      Console.WriteLine($"Your total is ${total}");
      Console.WriteLine("Thank you for shopping with us!");
    }
  }
}





  
  