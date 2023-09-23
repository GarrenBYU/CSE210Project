using System;
public class Entry
{
    public void Display()
    {
        string _promptText = PromptGenerator.GetRandomPrompt();
        Console.Write(_promptText);
    }
}