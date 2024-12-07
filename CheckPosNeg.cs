

using System;

public class CheckPosNeg
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
        if(iNo>0)
        {
            Console.WriteLine("This is a Positive No : "+iNo);
        }
        else
        {
            Console.WriteLine("This is a Negetive No : "+iNo);
        }
        
        Console.ReadKey();
    }
}