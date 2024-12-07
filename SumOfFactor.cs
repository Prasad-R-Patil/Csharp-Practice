



using System;

public class SumOfFactors
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        int Sum = 0;
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
      for(int i=1; i<=iNo; i++)
      {
          if(iNo%i == 0)
          {
              Console.WriteLine(i);
              Sum=Sum+i;
          }
          
      }
      Console.Write("Sum of Factor is ==> {0}",Sum);
      
       
        
        Console.ReadKey();
    }
}
        
        
       