using System.IO;
using System;
public class Journal
{
    public List<Entry> _entries;
    public void AddEntry( String Entry)
    {
        Entry newEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        Prompt newPrompt = new Prompt();
        newPrompt._prompts = new List<string>(){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        newEntry._question = newPrompt.GetRandomPrompt();
        Console.Write(newEntry._question);
        newEntry._answer = Console.ReadLine();
        string fileName = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine($"Date: {newEntry._date} - Prompt: {newEntry._question} \n{newEntry._answer}")
        }
        
    }
    public void DisplayAll(){
        string fileName = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    // public String SaveToFile(String file){

    // }
    // public String LoadFromFile(String file){

    // } 
}