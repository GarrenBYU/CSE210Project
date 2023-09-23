using System.IO;
using System;
public class Journal
{
    public List<Entry> _entries;
    public void AddEntry( String entry)
    {
        string fileName = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(entry);
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