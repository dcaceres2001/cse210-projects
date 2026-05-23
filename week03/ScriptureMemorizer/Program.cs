using System;

class Program
{
    static void Main(string[] args)
    {
       // My original code had the scripture hardcoded, but I changed it to allow user input for the scripture reference and text.      
       // Reference reference = new Reference("John", 3, 16);
       // Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Please enter the scripture book (e.g., 'John'):");
        string referenceInput = Console.ReadLine();
        Console.WriteLine("Please enter the scripture chapter:");
        string chapterInput = Console.ReadLine();
        Console.WriteLine("Please enter the scripture verse:");
        string verseInput = Console.ReadLine();
        Console.WriteLine("Please enter the scripture end verse:");
        string endVerseInput = Console.ReadLine();
        Console.WriteLine("Please enter the scripture text:");
        string scriptureText = Console.ReadLine();
        Reference reference = new Reference(referenceInput, int.Parse(chapterInput), int.Parse(verseInput), int.Parse(endVerseInput));
        Scripture scripture = new Scripture(reference, scriptureText);




        while (true)
        {
            //I was having issues debugging the console clear, so I added a try-catch block.
             try
            {
                Console.Clear();
            }
            catch (System.IO.IOException)
            {

                Console.WriteLine(new string('\n', 50));
            }


            Console.WriteLine(scripture.ToString());
            Console.WriteLine();


            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You've memorized the scripture!");
                break;
            }


            Console.WriteLine("Press Enter to hide a word, or type 'exit' to quit.");
            string input = Console.ReadLine();


            if (input?.ToLower() == "exit")
            {
                break;
            }


            scripture.HideRandomWords(3);
        }
    }
}

