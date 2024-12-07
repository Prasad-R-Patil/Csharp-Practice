
using System;

public class SumOfTwoNo
{
    public static void Main(string[] args)
    {
        int no1=0;
        int no2=0;
        Console.WriteLine ("Enter First Number");
        no1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        no2=Convert.ToInt32(Console.ReadLine());
        
        int Sum = no1 + no2;
        
        Console.WriteLine("The Sum is : {0}",Sum);
        Console.ReadKey();
        
    }
}