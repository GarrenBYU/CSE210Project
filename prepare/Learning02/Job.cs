public class Job
{
    public string __company;
    public string __jobTitle;
    public int __startYear;
    public int __endYear;
    
    public string Display()
    {
        return $"{__jobTitle} ({__company}) {__startYear}-{__endYear}";
    }
}