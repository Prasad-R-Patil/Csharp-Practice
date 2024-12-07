
using System;

public class SwapTwoNo
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        int Cnt = 0;
        
        Console.WriteLine("Enter Your Number : ");
        iNo = int.Parse(Console.ReadLine());
        
        if(iNo <= 1)
        {
            Console.WriteLine("it is Not Prime : {0}",iNo);
        }
        else
        {
            for(int i = 2; i<=iNo/2; i++)
            {
                if(iNo%i==0)
                {
                    Cnt++;
                }
            }
            if(Cnt>1)
            {
                Console.WriteLine("it is Not Prime No : {0}",iNo);
            }
            else
            {
                Console.WriteLine("it is Prime No : {0}",iNo);
            }
			
			//Cnt>1 ? Console.WriteLine("it is Not Prime No : {0}",iNo) : Console.WriteLine("it is Prime No : {0}",iNo); 
        }
        
        Console.ReadKey();
    }
}
        
        
       