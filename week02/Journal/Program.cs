using System;

class Program
{
    static void Main(string[] args)
    {
        
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry to your journal");
            Console.WriteLine("2. Display your journal");
            Console.WriteLine("3. Load your journal from a file");
            Console.WriteLine("4. Save your journal to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                //this part will let the user write a new entry to the journal using a random prompt from the PromptGenerator class
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {randomPrompt}");
                Console.Write("> ");
                string userResponse = Console.ReadLine();

                // this part creates a new Entry object with the random prompt and user response, then adds it to the journal
                Entry newEntry = new Entry(randomPrompt, userResponse);
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry recorded!\n");
            }

            // this part will display all the entries in the journal
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            // this part will load journal entries from a file specified by the user
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Loading file...");
                Console.WriteLine("File loaded successfully, to view entries, please select option 2.\n");
            }

            // this part will save the current journal entries to a file specified by the user
            else if (choice == "4")

            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("Saving to file...");
                Console.WriteLine("File saved successfully.\n");
            }
            else if (choice == "5")
            {
                running = false;
            }
        }
    }
}

