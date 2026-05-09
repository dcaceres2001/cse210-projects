using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        int guessInt = int.Parse(guess);

        while (guessInt != magicNumber)
        {
            Console.WriteLine("Wrong! Try again.");
            if (guessInt < magicNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else
            {
                Console.WriteLine("Your guess is too high.");
            }
            Console.WriteLine("What is your guess?");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
        }
        Console.WriteLine("You guessed it! What are the odds?!?");
    }
}