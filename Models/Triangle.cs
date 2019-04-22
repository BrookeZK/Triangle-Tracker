using System;

namespace TriangleSides {

  class Triangle
  {
    private int SideA;
    private int SideB;
    private int SideC;

    public Triangle(int sideA, int sideB, int sideC)
    {
      SideA = sideA;
      SideB = sideB;
      SideC = sideC;
    }

    public bool IsTriangle(int sideA, int sideB, int sideC)
    {
      return (sideA > 0 && sideB > 0 && sideC > 0 && sideA + sideB >= sideC && sideA + sideC >= sideB && sideB + sideC >= sideA);
    }
  }
}
