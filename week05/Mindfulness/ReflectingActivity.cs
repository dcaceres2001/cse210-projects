using System;

namespace Mindfulness
{
    class ReflectingActivity : Activity
    {
        public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on your experiences and gain insights.")
        {
        }

        public void Start()
        {
            DisplayStartMessage();
            Console.WriteLine("Take a moment to think about the following prompt:");
            Console.WriteLine("What is a recent experience that made you feel grateful?");
            Console.WriteLine("You have 30 seconds to reflect on this...");
            System.Threading.Thread.Sleep(30000); // Wait for 30 seconds
            DisplayEndMessage();
        }
    }
}

