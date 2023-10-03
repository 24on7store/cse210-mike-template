// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning02 World!");
//     }
// }



// using System;

// class Program
// {
//     static void Main()
//     {
//         // Create job instances
//         Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
//         Job job2 = new Job("Apple", "Manager", 2022, 2023);

//         // Display job information
//         job1.Display();
//         job2.Display();
//     }
// }


using System;

class Program
{
    static void Main()
    {
        // Create a resume instance
        Resume myResume = new Resume("Mackison Jean Pierre");

        // Create job instances and add them to the resume
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the entire resume
        myResume.Display();
    }
}
