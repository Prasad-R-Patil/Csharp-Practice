

using System;

public class FindFactorial
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
       for(int i=1; i<=iNo; i++)
       {
           if(iNo%i == 0)
           {
               Console.Write(" "+i);
           }
       }
        
        Console.ReadKey();
    }
}