using System;

class Program
{
    static void Main(string[] args)
    {
        
        string name = "";
        string lastName = "";

        Console.WriteLine("What is your first name? ");
        name = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}!");
    }
}