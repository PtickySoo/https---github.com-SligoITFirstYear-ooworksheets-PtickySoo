using System;

namespace demo
{
    class Circle
    {
      private int radius;

      public int Radius
      {
          get {return radius;}
          set {radius = value;}
      }

      public Circle()
      {
          radius = 1;
      }

      public Circle (int inputRadius)
      {
          Radius = inputRadius;
      }

      public double GetArea()
      {
          return radius*radius*3.14;
      }

     
    }
}