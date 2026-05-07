using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Enter your Grade Percentage: ");
        String gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);
        string letter = "";
        
        if (number >= 90 )
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (number >=70 )
        {
            Console.WriteLine("You Passed the course.. Congratulations");
        }
        else
        {
            Console.WriteLine("You did not meet the required Grade, Try Again next time!");
        }

    }
}