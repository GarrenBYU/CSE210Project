using System.IO;
using System;
public class Journal
{
    public List<Entry> _entries;
    public void AddEntry( String entry)
    {
        string fileName = "Temporary.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(entry);
        }
    }
    // public void DisplayAll(){

    // }
     public void SaveToFile(String file){
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
     }
    public void LoadFromFile(String file){
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("\n\n");
            string ogFileName = "Temporary.txt";
            using (StreamWriter outputFile = new StreamWriter(ogFileName)){
                outputFile.WriteLine(parts);
            }
        }
    } 
}