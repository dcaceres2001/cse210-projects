using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
            "What are you grateful for today?",
            "Describe a memorable moment from your day.",
            "What is something you learned recently?",
            "Write about a challenge you faced and how you overcame it.",
            "If I had one thing I could do over today, what would it be?",
            "What is something that made you smile today?",
            "Describe a person who had a positive impact on your day.",
            "What is a goal you have for tomorrow?",
            "How did I see the hand of the Lord in my life today?"
        };


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}




