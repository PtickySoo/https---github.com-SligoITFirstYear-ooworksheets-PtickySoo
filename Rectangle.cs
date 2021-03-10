using System;

namespace demo
{
    class Rectangle
    {
                  public int length;
                  public int width;

                  // methods
                   // constructor method - must call this before we can use the class
                  public Rectangle()
                  {
                  // creates an object with no values assigned to attributes
                  }

                  public Rectangle(int l, int w)
                   {
                  // creates an object with values assigned to attributes
                   length = l;
                   width = w;


                  }

           
          
                 public virtual string ToString() // special methods that tells us about the object
                  {
                 return "I am a rectangle with length " + length;
                  }

                  public int GetLength()
                  {
                      return length;
                  }

                  public void SetLength(int inputLength)
                  {
                      length = inputLength;
                  }

                  public int GetWidth()
                  {
                      return width;
                  }

                  public void SetWidth(int inputWidth)
                  {
                      length = inputWidth;
                  }

                  public int CalcArea()
                  {
                      return length*width;
                  }


    }
}