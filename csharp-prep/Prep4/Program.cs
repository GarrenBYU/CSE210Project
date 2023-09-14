using System;
using System.Globalization;
using System.Xml.XPath;
using System.Collections.Generic

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        String result = "";
        List<int> numbers = new List<int>();
        while (result != "0")
        {
            Console.Write("Enter number: ");
            result = Console.ReadLine();
            numbers.Add(int.Parse(result));
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        int listLength = numbers.Count;
        int average = sum / listLength;
        Console.WriteLine($"The average is: {average}")
    }
}