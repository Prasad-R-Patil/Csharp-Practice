
using System;


public class Calculeter
{
    public static void Main(string[] args)
    {
        string Conform;
        
        do
        {
        Console.WriteLine ("Enter First Number");
        int iNo1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter Second Number");
        int iNo2 = int.Parse(Console.ReadLine());
        
        int Sum = iNo1=iNo2;
        Console.WriteLine("Your Addtion is : {0}", Sum);
        
        Console.WriteLine("Do you want To Repeat Your Program ==> Yes/No");
        Conform = Console.ReadLine().ToLower();
        
        }while(Conform == yes);
        
        Console.WriteLine("Your Process Completed...");
        Console.WriteLine("Exit.......");
        
        
        Console.ReadKey();
    }
}