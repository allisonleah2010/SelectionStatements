using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the random number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            var guess = int.Parse(Console.ReadLine());

            if(guess < number)
            {
                Console.WriteLine("too low!");
            }
            else if(guess > number)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Nevermind!");
            }


            Console.WriteLine("What's your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a tough subject");
                    break;
                case "Science":
                    Console.WriteLine("Science is an awesome subject!");
                    break;
                case "English":
                    Console.WriteLine("English is an awesome subject!");
                    break;
                case "Chemistry":
                    Console.WriteLine("Chemistry is a boring subject!");
                    break;
                case "Reading":
                    Console.WriteLine("Reading is good for the soul!");
                    break;
                case "Computer Class":
                    Console.WriteLine("You are a smart cookie!");
                    break;
                default:
                    Console.WriteLine($"I guess {subject} is cool too!");
                    break;
            }




        }
    }
}