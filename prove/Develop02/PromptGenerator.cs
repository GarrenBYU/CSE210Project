using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int initialNumber = randomGenerator.Next(1, 5);
        List<string>  _prompts = new List<string>(){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        string _firstPrompt = _prompts[initialNumber];
        return _firstPrompt;
    }
}