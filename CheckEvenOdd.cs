

using System;

public class CheckEvenOdd
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
        if(iNo % 2 == 0)
        {
            Console.WriteLine("This is a Even No : "+iNo);
        }
        else
        {
            Console.WriteLine("This is a Odd No : "+iNo);
        }
        
        Console.ReadKey();
    }
}