using System;
using System.Globalization;
using System.Xml.XPath;
using System.Collections.Generic;

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
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (largest < number)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        double listLength = numbers.Count;
        double average = sum / (listLength - 1);
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}