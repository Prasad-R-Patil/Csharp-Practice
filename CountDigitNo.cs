



using System;

public class CountDigitNo
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        int Cnt = 0;
        
        
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
       
        
        while(iNo != 0)
        {
            
           iNo = iNo/10;
           ++Cnt;
            
        }
        
        Console.WriteLine(Cnt);
       
        
        Console.ReadKey();
    }
}
        
        
       