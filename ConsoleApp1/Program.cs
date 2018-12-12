using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to my guessing game");

            //Generate a random number
            Random rng = new Random();
            int r= rng.Next(1, 100);

            //Display the random number
            Console.WriteLine(r);

            Console.WriteLine("Tap the screen to begin");

            //User has 100 attempts
            for (int i = 0; i < 100; i++)
            {
                string input;
                input = Console.ReadLine();

                Console.WriteLine("Guess");

                //Console.Write("You entered {0}", input);
               
                int guessNo;

                if (Int32.TryParse(input, out guessNo)) {
                    
                }
 
                if (guessNo < r)
                {
                    Console.WriteLine("smaller");
                }

                else if (guessNo > r)
                {
                    Console.WriteLine("bigger");
                }

                else if (guessNo == r)
                {
                    Console.Write(" and guessed!");
                    Console.WriteLine();
                    Environment.Exit(0);
                }
            }
        }
    }
}
