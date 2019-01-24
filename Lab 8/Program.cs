using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab8
{
    class Program
    {
        static int promptUserAndReadInteger()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number 1-15");
                    int num = int.Parse(Console.ReadLine());
                    if (num > 0 && num <= 15)
                    {
                        return num;
                    }
                    else
                        throw new IndexOutOfRangeException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("That student does not exist");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is invalid data. (enter a number 1-19)");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Welcome to our C# class" + (" "));
            string[] hometown = { "San Diego, CA", "Raleigh, NC", "Perrysburg, OH", "Oak Park, MI", "Waterville, OH", "DETROIT!!!", "Sterling Heights, MI", "Warren, MI", "Lincoln Park, MI", "Albuquerque, NM", "Detroit, MI", "Toledo, OH", "Battle Creek, MI", "Oakland, CA", "Gary, IN" };
            string[] favFood = { "Burgers", "Chicken Curry", "Pizza", "Veggie Burgers & Fries", "Grilled Octopus", "Pizza", "Pizza", "Quesadillas", "Saganaki", "Bibimbap", "Wraps", "Chinese", "Pasta", "Mac & Cheese", "Chicken" };
            string[] students = { "Karrar", "Tommy", "Steve", "Kendra", "Evan", "Levi", "Kent", "Ronald", "Laura", "Jacky", "Brian", "Noha", "Stephen", "Mauricio", "Rudy" };

            bool right = true;
            while (right == true)
            {
                int userInput = promptUserAndReadInteger(); //Stores the number that the user inputs.
                string numericalStudent = students[userInput - 1];
                Console.WriteLine($"{userInput} is {numericalStudent}");
                Console.Write($"What would you like to know about {numericalStudent}, Food or Hometown?");
                string choices = Console.ReadLine().ToLower();
                if (choices == "hometown")
                {
                    Console.WriteLine($"{numericalStudent} is from {hometown[userInput - 1]}");
                }
                else if (choices == "food")
                {
                    Console.WriteLine($"{numericalStudent} loves {favFood[userInput - 1]}!");
                }
                else
                {
                    Console.Write("That data does not exist. Please try again.");
                }
                right = Continue();
            }
        }
        public static bool Continue()
        {                
        
        Console.WriteLine("Would you like to know another student? (y/n)");
        string doAgain = Console.ReadLine().ToLower();
        bool again = true;

        if (doAgain == "y" || doAgain == "yes")
        {
            again = true;
        }
        else if (doAgain == "n" || doAgain == "no")
        {
            Console.WriteLine("Goodbye!");
            again = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Try again.");
            again = Continue();
        }
        return again;
    }
        
    }
}






