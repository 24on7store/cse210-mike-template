// using System; dotnet


// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep1 World!");
//     }
// }

// //week 01 exercises
// //#1
// int x;
// x = 5;
// Console.WriteLine(x);
// or
// int x = 5;
// Console.WriteLine(x);

//more practice
//Console.WriteLine("Hello world!");

//Console.Write("There will be a new line after this.");

//Input
// Console.Write("What is your favorite color? ");
// string color = Console.ReadLine();

//Curly braces define blocks
// if (x > y)
// {
//     Console.WriteLine("greater");
// }

// in Python It would be like that
// if x>y:
// print("greater")

//String Interpolation python vs C#
// Python
// school = "BYU-Idaho"
// print(f"I am studying at {school}")

//  C#
// string school = "BYU-Idaho";
// Console.WriteLine($"I am studying at {school}. ");

// Console.WriteLine("What is your first name? ");
// string firstname = Console.ReadLine();

// Console.Write("What is your last name? ");
// string lastname = Console.Write();

// //Console.WriteLine($"My name is {lastname}, {firstname} {lastnme}. ");
// Console.WriteLine("My name is: " + lastname, + firstname + firstname);


namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine();
      // Type your username and press enter
      Console.Write("What is your first name: ");
      string firstName = Console.ReadLine();
      Console.Write("What is your last name: ");
      string lastName = Console.ReadLine();

    //   // Create a string variable and get user input from the keyboard and store it in the variable
    //   string firstName = Console.ReadLine();
    //   string lastName = Console.ReadLine();

      // Print the value of the variable (userName), which will display the input value
      //Console.WriteLine("My name is: " + lastName +,  lastName + firstName);
       Console.WriteLine();
       Console.WriteLine($"My name is {lastName}, {firstName} {lastName}. ");
       Console.WriteLine();
    }
  }
}

