using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int nrRandom = generator.Next(0, 100);
            
            int nrUser;
            
            do 
            {
                Console.WriteLine("Enter a number");
                string nrString = Console.ReadLine();
                nrUser = int.Parse(nrString);
            
                if (nrUser < nrRandom)
                {
                    Console.WriteLine("Increase the number");
                }
            
                if (nrUser > nrRandom)
                {
                    Console.WriteLine("Decrease the number");
                }
            }
            while (nrUser != nrRando
                    
            Console.writeLine("Guessed");
                
            
        }       
    }
}
