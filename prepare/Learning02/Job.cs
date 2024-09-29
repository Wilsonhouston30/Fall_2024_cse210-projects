public class Job
{
    public string job_title;
    public string company_name;
    public int start_year;

    public int end_year;



    public void Display()
    {
        Console.WriteLine($"{company_name}: {job_title} {start_year} - {end_year}." );

    }

    public int Tenure(int start_year, int end_year)
    {
        int tenure = end_year - start_year;
        return tenure;
    }
}