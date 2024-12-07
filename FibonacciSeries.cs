
using System;

public class FibonacciSequence
{
    public static void Main(string[] args)
    {
        int No1 = 0;
        int No2 = 1;
        int NextNo = 0;
        int Value = 0;
        
        Console.WriteLine ("Enter Positive Number :- ");
        Value = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Fibonacci Series:");
        
        Console.WriteLine(No1);
        Console.WriteLine(No2);
        
        NextNo = No1+No2;
        
        while(NextNo <= Value)
        {
            Console.WriteLine(NextNo);
            
            No1 = No2;
            No2 = NextNo;
            NextNo = No1+ No2;
           
        }
        
        Console.ReadKey();
        
        
    }
}