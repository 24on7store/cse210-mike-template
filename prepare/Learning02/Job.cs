
using System;

public class Job
{
    // Member variables for job details
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    // Constructor to initialize job details
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job information
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
