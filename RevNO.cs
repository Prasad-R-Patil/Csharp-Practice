



using System;

public class RevNo
{
    public static void Main(string[] args)
    {
        int iNo = 0;
        int Rev = 0;
        
        
        Console.WriteLine("Enter Your Number : ");
        iNo = Convert.ToInt32(Console.ReadLine());
        
      
         while(iNo != 0)
         {
             Rev=iNo%10;
             Console.Write(Rev);
             iNo=iNo/10;
             
         }
      
       
        
        Console.ReadKey();
    }
}
        
        
       