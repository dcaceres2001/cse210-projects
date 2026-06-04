using System;


namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by focusing on your breathing.")
        {
        }

        public void Start()
        {
            DisplayStartMessage();
            // Implement the breathing exercise logic here
            // For example, you could have a loop that guides the user through inhaling and exhaling
            DisplayEndMessage();
        }
    }
}

      
