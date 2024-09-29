using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // Creating two instances from the Job class
        Job job1 = new Job();
        job1.job_title = "Software Egnineer";
        job1.company_name = "Apple";
        job1.start_year = 1999;
        job1.end_year = 2024;


        Job job2 = new Job();
        job2.job_title = "IT Consultant";
        job2.company_name = "Sunrun";
        job2.start_year = 2000;
        job2.end_year = 2024;


        

        
        Console.Clear();
        Resume resume1 = new Resume();
        resume1._name = "Wilson Houston";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}