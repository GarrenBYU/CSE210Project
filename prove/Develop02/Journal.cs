using System;
using System.IO;
public class Journal
{
    public List<String> _entries = new List<String>();
    public void AddEntry(String entry)
    {
        
        this._entries.Add(entry);
        this._entries.Add(" ");
    }
    public void DisplayAll(){
        foreach(string entry in this._entries){
            Console.WriteLine(entry);
        }
    }
     public void SaveToFile(String file){
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName)){

            foreach(string entry in this._entries)
            {
                outputFile.WriteLine(entry);
            }
        }
     }
    public void LoadFromFile(String file){
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i++)
        {
            //string[] parts = line.Split(",");
            this._entries.Add(lines[i]);
        }
        //this._entries.Add('\n');
    } 
}