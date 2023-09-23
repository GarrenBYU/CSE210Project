using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry entry)
    {
        
        this._entries.Add(entry);
    }
    public void DisplayAll(){
        foreach(Entry entry in this._entries){
            Console.WriteLine(entry.Display());
        }
    }
     public void SaveToFile(String file){
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName)){

            foreach (string entry in this._entries)
            {
                Console.WriteLine(entry);
            }
        }
     }
    public void LoadFromFile(String file){
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        }
    } 
}