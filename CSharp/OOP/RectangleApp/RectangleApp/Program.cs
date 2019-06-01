using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleApp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.width = 10;
            small.height = 5;
            Rectangle big = new Rectangle();
            big.width = 100;
            big.height = 20;
            Console.WriteLine("Width = " + big.width + " and height = " + big.height);
            Console.WriteLine("Area of big rectangle = " + big.CalculateArea());
            Console.WriteLine("Width = " + small.width + " and height = " + small.height);
            Console.WriteLine("Area of small rectangle = " + small.CalculateArea());
            

                  // changed one

             Rectangle[] rect = new Rectangle[3];
            for (int i = 0; i < 3; i++)
            {
                rect[i] = new Rectangle();
            }
            rect[0].width = 10;
            rect[0].height = 20;

            rect[1].width = 50;
            rect[1].height = 30;

            rect[2].width = 60;
            rect[2].height = 50;

             int[] area = new int[3]; 

              for (int i = 0; i < 3; i++) {
                  area[i] = rect[i].CalculateArea();
              }
              for(int i=0;i<3;i++)
              {
                  Console.WriteLine("Area of "+ (i+1) +"th rectangle is :" + area[i]);
              }
              int total = 0;
              for (int i = 0; i < 3; i++)
                  total = total + area[i];
              Console.WriteLine("Sum of areas of rectangle is " + total); 
      

            
        }
    }
}
