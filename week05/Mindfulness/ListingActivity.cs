using System;
using System.Threading;

namespace Mindfulness
{
    class ListingActivity : Activity
    {
        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on positive aspects of your life by listing them.")
        {
        }

        public void Start()
        {
            DisplayStartMessage();
            Console.WriteLine("Take a moment to think about the following prompt:");
            Console.WriteLine("What are three things you are grateful for today?");
            Console.WriteLine("You have 30 seconds to list them...");
            Thread.Sleep(30000); // Wait for 30 seconds
            DisplayEndMessage();
        }
    }
}

