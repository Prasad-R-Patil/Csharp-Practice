
using System;

public class ArmstrongNumber
{
    public static void Main(string[] args)
    {
        int No = 0;
        int Temp = 0;
        int Sum = 0;
        
        Console.WriteLine ("Enter Your Number :- ");
        No = Convert.ToInt32(Console.ReadLine());
        
        Temp = No;
        
        int Length = No.ToString().Length;
        
        while (Temp > 0)
        {
            int Digit = Temp%10;
            Sum = Sum+(int)Math.Pow(Digit,Length);
            Temp = Temp/10;
        }
        
        if (Sum == No)
        {
             Console.WriteLine($"{No} is an Armstrong number.");
        }
           
        else
        {
            Console.WriteLine($"{No} is not an Armstrong number.");
        }
            
       
        
        Console.ReadKey();
        
        
    }
}