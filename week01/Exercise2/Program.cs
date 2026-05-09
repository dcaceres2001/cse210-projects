using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your grade");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string gradeLetter = "";

        if (gradeInt >= 90)
        {
             gradeLetter = "A";
        }
        else if (gradeInt >= 80)
        {
             gradeLetter = "B";
        }
        else if (gradeInt >= 70)
        {
             gradeLetter = "C";
        }
        else if (gradeInt >= 60)
        {
             gradeLetter = "D";
        }
        else
        {
             gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }


    }
}