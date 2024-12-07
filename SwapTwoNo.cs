



using System;

public class SwapTwoNo
{
    public static void Main(string[] args)
    {
        int iNo1 = 0;
        int iNo2 = 0;
        
        
        
        Console.WriteLine("Enter Your First Number : ");
        iNo1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Your Second Number : ");
        iNo2 = Convert.ToInt32(Console.ReadLine());
        
      /*
         iNo1 = iNo1 + iNo2;
         iNo2 = iNo1 - iNo2;
         iNo1 = iNo1 - iNo2;
        */
        
            int Temp;
            Temp = iNo1;
            iNo1 = iNo2;
            iNo2 = Temp;
            
         Console.WriteLine("Your No Swapped : {0} {1} ", iNo1 , iNo2);
      
       
        
        Console.ReadKey();
    }
}
        
        
       