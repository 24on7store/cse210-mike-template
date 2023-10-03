// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep2 World!");
//     }
// }


// c#
// if (x > y)
// {
//     Console.WriteLine("greater than");
// }

// python
// if x > y:
// print("greater than")

// if (x > y)
// {
//     if (x > z)
//     {
//         Console.WriteLine("greater than both");
//     }
// }



// //Exercises
// namespace MyApplication
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {

//       Console.WriteLine();
//       // Type your username and press enter
//       Console.Write("What is your grade percentage: ");
//       string my_grade_percentage = Console.Read();

//       if (my_grade_percentage == 90)

//       {
//         Console.WriteLine("A");
//       }

//        Console.WriteLine();
//     }
//   }


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string answer = Console.ReadLine();
        int grade_percentage = int.Parse(answer);

        string letter = "";


        if (grade_percentage >= 90)
        {
            letter = "A";
        }
            Console.WriteLine($"Your grade is: {letter}");
            Console.WriteLine("Congratulations! Your grade is over 89. ");


        // else if (grade_percentage >= 80)
        // {
        //     letter = "B";
        // }
        //  Console.WriteLine($"Your grade is: {letter}");
        //  Console.WriteLine("Congratulations! Your grade is over 79. ");


        // else if (grade_percentage >= 70)
        // {
        //     letter = "C";
        // }
        //  Console.WriteLine($"Your grade is: {letter}");
        //  Console.WriteLine("You passed! Your grade is over 69 and less than 80. ");



        // else if (grade_percentage>= 60)
        // {
        //     letter = "D";
        // }
        //  Console.WriteLine($"Your grade is: {letter}");
        //  Console.WriteLine("Better Luck next time! Your grade is less than 70 which is the min to pass. ");


        // elif if (grade_percentage < 60)
        // {
        //     letter = "F";
        // }
        //  Console.WriteLine($"Your grade is: {letter}");
        // Console.WriteLine("Congratulations! Your grade is less than 60. ");
        // Console.WriteLine("I encourage you to retake this exam ");
       
    }
}




// using System;

// namespace MyApplication
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Type your grade percentage and press enter
//             Console.Write("What is your grade percentage: ");
            
//             // Use Console.ReadLine() to read a string from the console
//             string input = Console.ReadLine();

//             // Convert the input to an integer using int.Parse()
//             if (int.Parse(input, out int myGradePercentage)) // Check if parsing is successful
//             {
//                 if (myGradePercentage >= 90)
//                 {
//                     Console.WriteLine("A");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Your grade is below A.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a valid number.");
//             }
//         }
//     }
// }
