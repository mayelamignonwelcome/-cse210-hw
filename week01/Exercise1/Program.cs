using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("what is your first name? ");
        String FirstName = Console.ReadLine();
        Console.Write("what is your last name? ");
        String LastName= Console.ReadLine();
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}