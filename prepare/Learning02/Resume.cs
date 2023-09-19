public class Resume
{
    public string __name;
    public List<Job> __jobs = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {__name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in __jobs)
        {
            job.Display();
        }
    }
}