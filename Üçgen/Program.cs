using System;

﻿namespace triangleCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape triangle = new shape();
            Console.WriteLine("Ucgenin kenar uzunlugunu giriniz: ");
            int value = int.Parse(Console.ReadLine());
            triangle.triangle(value);
        }
    }
}