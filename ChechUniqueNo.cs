
using System;

public class CheckUniqueNo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Number :- ");
        String No = Console.ReadLine();
        
        int duplicateCount = 0;
        
        for(int i = 0; i <No.Length; i++)
        {
            for(int j=i+1; j<No.Length; j++)
            {
                 if (No[i] == No[j])
                {
                    duplicateCount++;
                    break; 
                }
            }
            if (duplicateCount > 0)
                break; 
        }
        
        if (duplicateCount == 0)
        {
            Console.WriteLine($"{No} is a Unique Number.");
        }
            
        else
        {
             Console.WriteLine($"{No} is not a Unique Number.");
        }
           
        
       
        
        Console.ReadKey();
        
        
    }
}