using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        int userInput = -1;
        while (userInput !=0)
        {
            Console.WriteLine("Enter series of number, Type 0 to stop");
            string userResponse = Console.ReadLine();
            userInput= int.Parse(userResponse);

            if (userInput != 0)
            {
               numbers.Add(userInput); 
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;

        }
         Console.WriteLine($"The sum is: {sum}");

         // Calculating for Average
         float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers [0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            

        }
        Console.WriteLine($"The max is: {max}");
    }
    
}