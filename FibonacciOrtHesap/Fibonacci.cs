namespace fibOrtHesp;

public class Fibonacci
{   
    public void CreateFibonacci(int Sayi)
    {
        int[] arrayFibo = new int[Sayi];
        arrayFibo[0]=0;
        arrayFibo[1]=1;
        for (int i = 2; i < Sayi; i++)
        {   
            arrayFibo[i]=arrayFibo[i-1]+arrayFibo[i-2];   
        }
         int ortalama = arrayFibo.Sum()/arrayFibo.Length;

        Console.WriteLine("[{0}]", string.Join(", ", arrayFibo)); 
        System.Console.WriteLine("Fibonachi dizisinin ortalamasi : {0}",ortalama);  
    }

    public void CreateFibonacci(int Sayi,int ilk,int ikinci)
    {
        int[] arrayFibo = new int[Sayi];
        arrayFibo[0]=ilk;
        arrayFibo[1]=ikinci;
        for (int i = 2; i < Sayi; i++)
        {   
            arrayFibo[i]=arrayFibo[i-1]+arrayFibo[i-2];   
        }
         int ortalama = arrayFibo.Sum()/arrayFibo.Length;

        Console.WriteLine("[{0}]", string.Join(", ", arrayFibo)); 
        System.Console.WriteLine("Fibonachi dizisinin ortalamasi : {0}",ortalama);  
    }
}