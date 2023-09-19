public class Job
{
    public string __company;
    public string __jobTitle;
    public int __startYear;
    public int __endYear;
    
    public void Display()
    {
        Console.WriteLine($"{__jobTitle} ({__company}) {__startYear}-{__endYear}");
    }
}