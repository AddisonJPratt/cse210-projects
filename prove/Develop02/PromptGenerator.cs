using System;
using System.Collections.Generic;

public class PromptGenerator
{


    public List<string> prompts = new List<string>(){
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What did you eat for food today?",
    "Was there someone that you served or could've served?",
};
    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];

    }
}

