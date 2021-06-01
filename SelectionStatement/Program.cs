using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 9;

            Console.WriteLine($"Pick your favorite number. Hint: Its below 10.");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine($"Too Low guess again.");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine($"Nope, too high. TRY AGAIN..");
            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("Got it. Good Job!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }


        }
    }
}
