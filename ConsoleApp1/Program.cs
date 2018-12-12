using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            enterName:
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName} {lastName}";

            if (firstName.Equals(lastName))
            {
                Console.WriteLine("Invalid Name");
                goto enterName;
            }

            Console.WriteLine("Enter your age");
            string InputAge = Console.ReadLine();
            int age;
            if (Int32.TryParse(InputAge, out age))
            {

            }

            if (age < 14)
            {
                Console.WriteLine("You shouldn't be under 14 yo");
                goto exit;    
            }
         
            Console.WriteLine();
            
            Console.WriteLine("Welcome to my guessing game");

            //Generate a random number
            Random rng = new Random();
            
            int random = rng.Next(1, 100);

            Console.WriteLine("                                             tip: {0}", random);

            Console.WriteLine("Try with a number");

            //User has 100 attempts
            for (int i = 0; i < 100; i++)
            {
                string input;
                input = Console.ReadLine();

                Console.WriteLine("Guess");

                Console.Write("You entered {0} ", input);

                int guessNo;

                if (Int32.TryParse(input, out guessNo))
                {

                }

                if (guessNo < random)
                {
                    Console.WriteLine("that is smaller");
                }

                else if (guessNo > random)
                {
                    Console.WriteLine("that is bigger");
                }

                else if (guessNo == random)
                {
                    Console.Write("and guessed!");
                    Console.WriteLine();
                    Console.WriteLine("Congrats {0}!", fullName);
                    
                    Environment.Exit(0);
                }
            }
            exit:
            Environment.Exit(0);
        }       
    }
}
