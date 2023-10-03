using System;
using System.Collections.Generic;

public class Resume
{
    // Member variable for the person's name
    private string _personName;
    // Member variable to store a list of jobs
    private List<Job> _jobs;

    // Constructor to initialize resume details
    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>();
    }

    // Method to add a job to the list of jobs
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display the resume
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}
