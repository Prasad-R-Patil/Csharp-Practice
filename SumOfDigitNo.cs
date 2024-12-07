



using System;

public class SumOfDigitNo
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        
        int Digit = 0;
        int Sum= 0;
        
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
       
        
        while(iNo != 0)
        {
            
           Digit = iNo%10;
           Sum=Sum+Digit;
           iNo = iNo/10;
          
        }
        
        Console.WriteLine(Sum);
       
        
        Console.ReadKey();
    }
}
        
        
       