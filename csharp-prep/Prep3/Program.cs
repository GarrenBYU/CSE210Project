using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int initialNumber = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        if (initialNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (initialNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}