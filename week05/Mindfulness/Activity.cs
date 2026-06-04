using System;
using System.Collections.Generic;

namespace Mindfulness
{
    class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartMessage()
        {
            Console.WriteLine($"Starting {_name}...");
            Console.WriteLine(_description);
            Console.WriteLine("Get ready...");
            // Add a countdown or timer here if desired
        }

        public void DisplayEndMessage()
        {
            Console.WriteLine($"Well done! You have completed {_name} for {_duration} seconds.");
        }

        public void SetDuration(int duration)
        {
            _duration = duration;
        }
    }
}