using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment1 = new Assignment("John Doe", "Math");
            Console.WriteLine(assignment1.GetSummary());

            MathAssignment mathAssignment1 = new MathAssignment("Jane Smith", "Math", "Section 5.2", "Problems 1-10");
            Console.WriteLine(mathAssignment1.GetSummary());
            Console.WriteLine(mathAssignment1.GetHomeworkList());

            WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
            Console.WriteLine(writingAssignment1.GetSummary());
            Console.WriteLine(writingAssignment1.GetWritingInformation());
        }
    }

}
