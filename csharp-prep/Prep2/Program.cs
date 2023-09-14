using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        String letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade >= 70){
            Console.WriteLine($"Congrats on passing your class with a {letter}!");
        }
        else
        {
            Console.WriteLine($"You did not pass this time around and got an F. Next time try to study.");
        }
    }
}