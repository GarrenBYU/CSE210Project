using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1.__jobTitle = "Software Engineer";
        job1.__company = "Microsoft";
        job1.__startYear = 2023;
        job1.__endYear = 2025;
        
        Job job2 = new Job();

        job2.__jobTitle = "QA Engineer";
        job2.__company = "Apple";
        job2.__startYear = 2023;
        job2.__endYear = 2025;
        Console.WriteLine(job1.__company);
        Console.WriteLine(job2.__company);
    }
}