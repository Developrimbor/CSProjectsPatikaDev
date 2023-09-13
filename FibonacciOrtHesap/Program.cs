﻿namespace fibOrtHesp;
class Program
{
    static void Main(string[] args)
    {
        Fibonacci array =new Fibonacci();
        System.Console.Write("\n Bir Sayı Giriniz : ");
        int Sayi = Convert.ToInt32(Console.ReadLine());
        array.CreateFibonacci(Sayi);        
    }
}