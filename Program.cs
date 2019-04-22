using System;
using System.Collections.Generic;

namespace TriangleSides {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Side A");
      string stringOfSideA = Console.ReadLine();
      int sideA = int.Parse(stringOfSideA);

      Console.WriteLine("Enter Side B");
      string stringOfSideB = Console.ReadLine();
      int sideB = int.Parse(stringOfSideB);

      Console.WriteLine("Enter Side C");
      string stringOfSideC = Console.ReadLine();
      int sideC = int.Parse(stringOfSideC);

      Triangle userTriangle = new Triangle(sideA, sideB, sideC);

      if (userTriangle.IsTriangle(sideA, sideB, sideC))
      {
        if (sideA == sideB && sideB == sideC)
        {
          Console.WriteLine("You got a sweet fine Equilateral Triangle, Friend.");
        }
        else if (sideA == sideB || sideA == sideC || sideB == sideC)
        {
          Console.WriteLine("WOW. W.O.W. Wowzeee: welcome, Friend: you have a Isosceles Triangle.");
        }
        else
        {
          Console.WriteLine("Eyyyyyyyyyyyyyy!!!!!! Friend, welcome Friend, your Friend, Scalene Triangle.");
        }
      }
      else
      {
        Console.WriteLine("This is not Triangle");
      }

      Main();
    }
  }
}
