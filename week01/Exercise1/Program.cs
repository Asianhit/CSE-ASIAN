using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        String fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        String lname =  Console.ReadLine();
        Console.WriteLine($"Your is is {lname}, {fname} {lname}.");
        

    }
}