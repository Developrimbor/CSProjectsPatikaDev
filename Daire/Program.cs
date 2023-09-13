using System;

namespace CircleShape
{
   class Shape
   {
      static void Main(string[] args)
      {
         int radius = 5;
         double console_ratio = Convert.ToDouble(4.5 / 2.0);
         double a = console_ratio * radius;
         double b = radius;

         for (int y = -radius; y <= radius; y++)
         {
            for(double x = -a; x <= a; x++)
            {
               double d = (x / a) * (x / a ) + (y / b) * (y / b);

               if(d > 0.90 && d < 1.2)
               {
                  Console.Write("*");
               }
               else
               {
                  Console.Write(" ");
               }
            }
            Console.Write("\n");
         }
         Console.Read();
      }
   }
}