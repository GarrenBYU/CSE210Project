using System;
public class Entry
{
    public string _question;
    public string _date;
    public string _answer;
    public void Display()
    {
        string fileName = "Temporary.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}