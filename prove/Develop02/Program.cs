using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Xml.Serialization;

class Program
{
    enum MenuItem
    {
        Write = 1,
        Display = 2,
        Load = 3,
        Save = 4,
        Quit = 5
    }
    static void Main(string[] args)
    {
        var newJournal = new Journal();
        var newEntry = new Entry();
        // newJournal._entries;

        Console.WriteLine("Welcome to the Journal Program!");
        var choice = MenuItem.Save;
        while(choice != MenuItem.Quit){
            Console.WriteLine("Hello {0} {0} how are you", "Garren");
            Console.WriteLine($"");
            Console.WriteLine(@"Hello Clay C:\temp");
            Console.WriteLine("""
Hello world "H4llo clay"
Next Line
Part3
""");
            Console.Write("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \nWhat would you like to do? ");
            choice = (MenuItem) int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case MenuItem.Write:
                    WriteMenuCode(newEntry, newJournal);
                    break;
                case MenuItem.Display:
                    newJournal.DisplayAll();
                    break;
                case MenuItem.Load:
                    Console.Write("What is the file name? ");
                    var fileName = Console.ReadLine();
                    newJournal.LoadFromFile(fileName);
                    break;
                case MenuItem.Save:
                    Console.Write("What is the file name? ");
                    var fileName = Console.ReadLine();
                    newJournal.SaveToFile(fileName);
                    break;
                case MenuItem.Quit:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private static void WriteMenuCode(Entry newEntry, Journal newJournal)
    {
        var newPrompt = new Prompt();
        newPrompt._prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        var theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        newEntry._question = newPrompt.GetRandomPrompt();
        Console.Write($"{newEntry._question} \n >");
        newEntry._answer = Console.ReadLine();
        //string entry = $"Date: {newEntry._date} - Prompt: {newEntry._question} \n{newEntry._answer}";
        newJournal.AddEntry($"Date: {newEntry._date} - Prompt: {newEntry._question} \n{newEntry._answer}");
    }
}