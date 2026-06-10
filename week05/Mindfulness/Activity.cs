using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public abstract class Activity
    {
        private string _name;
        private string _description;
        protected int _duration;
        private static List<string> _activityLog = new List<string>();

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Run()
        {
            DisplayStartingMessage();
            ExecuteActivity();
            DisplayEndingMessage();
        }

        protected abstract void ExecuteActivity();

        private void DisplayStartingMessage()
        {
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description);
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid positive number for seconds: ");
            }

            Console.WriteLine("Get ready...");
            ShowSpinner(3);
            Console.WriteLine();
        }

        private void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(3);

            // Log the activity
            _activityLog.Add($"{_name} - {_duration} seconds");

            // I have added this to show the activity log after each session. 
             Console.WriteLine($"\nSessions completed this run: {_activityLog.Count}");
            Console.WriteLine("Activity Log:");
            foreach (string entry in _activityLog)
            {
                Console.WriteLine($"  - {entry}");
            }
        }

        protected void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string frame = animationStrings[i];
                Console.Write(frame);
                Thread.Sleep(100);
                Console.Write("\b");

                i++;
                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }

            Console.Write(" \b");
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                string display = i.ToString();
                int len = display.Length;
                Console.Write(display);
                Thread.Sleep(1000);
                Console.Write(new string('\b', len) + new string(' ', len) + new string('\b', len));
            }
        }
    }
}