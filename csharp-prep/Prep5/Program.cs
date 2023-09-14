using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int favNumber = PromptUserNumber();
        int square = SquareNumber(favNumber);
        DisplayResult(name, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int favNum)
    {
        int square = favNum * favNum;
        return square;
    }
    static void DisplayResult(String name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}