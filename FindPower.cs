



using System;

public class FindPower
{
    public static void Main(string[] args)
    {
        int Base = 1;
        int Power = 1;
        int Sum = 1;
        
        
        
        Console.WriteLine("Enter Your Base Number : ");
        Base = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Your Power Number");
        Power = Convert.ToInt32(Console.ReadLine());
        
        while(Power != 0)
        {
            Sum = Sum*Base;
            Power--;
        }
        
        Console.WriteLine("The Power is : "+Sum);
       
        
        Console.ReadKey();
    }
}
        
        
       