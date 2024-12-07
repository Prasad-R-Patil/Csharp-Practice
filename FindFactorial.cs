

using System;

public class FindFactorial
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        int Sum = 1;
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i<=5; i++)
        {
             Sum = Sum*i;
        }
        Console.WriteLine("The Factorial is : "+Sum);
        
        Console.ReadKey();
    }
}