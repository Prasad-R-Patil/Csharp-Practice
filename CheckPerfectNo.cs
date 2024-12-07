
using System;

public class CheckPerfectNo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Number :- ");
        int No = Convert.ToInt32(Console.ReadLine());
        
        int Sum = 0;
        
        for(int i=1; i<=No/2; i++)
        {
            if(No%i==0)
            {
                Sum = Sum +i;
            }
        }
            
            if(Sum==No && No>0)
            {
                Console.WriteLine($"{No} ==> is a Perfect Number");
            }
            else
            {
                Console.WriteLine($"{No} ==> is Not a Perfect Number");
            }
       
        
        Console.ReadKey();
        
        
    }
}