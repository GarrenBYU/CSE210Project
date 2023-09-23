using System;
using System.Diagnostics.Contracts;
using System.IO;

class Program
{
    
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        Entry newEntry = new Entry();

        Console.WriteLine("Welcome to the Journal Program!");
        Console.Write("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \nWhat would you like to do? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1) {
            Prompt newPrompt = new Prompt();
            newPrompt._prompts = new List<string>(){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            };
            DateTime theCurrentTime = DateTime.Now;
            newEntry._date = theCurrentTime.ToShortDateString();
            newEntry._question = newPrompt.GetRandomPrompt();
            Console.Write($"{newEntry._question} \n >");
            newEntry._answer = Console.ReadLine();
            string entry = $"Date: {newEntry._date} - Prompt: {newEntry._question} \n{newEntry._answer}";
            newJournal.AddEntry(entry);
        }
        else if(choice == 2){
            newEntry.Display();
        }
        else if(choice == 3){
            Console.Write(" ");
            string fileName = Console.ReadLine();
            newJournal.LoadFromFile(fileName);
        }
        else if(choice == 4){
            Console.Write("What is the file name? ");
            string fileName = Console.ReadLine();
            newJournal.SaveToFile(fileName);
        }
    }
}