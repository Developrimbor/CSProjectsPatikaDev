using System;

namespace triangleCreate
{
    class shape
    {
        public void triangle(int value)

        {
            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j <= value - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}