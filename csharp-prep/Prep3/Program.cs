using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int initialNumber = randomGenerator.Next(1, 100);
        String result;
        int guess;
        do{
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (initialNumber > guess)
            {
                result = "Higher";
            }
            else if (initialNumber < guess)
            {
                result = "Lower";
            }
            else
            {
                result = "You guessed it!";
            }
            Console.WriteLine(result);
        } while (result != "You guessed it!");
    }
}