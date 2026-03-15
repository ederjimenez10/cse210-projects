using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        

        // Console.Write("What is the magic number? ");
        // string ask = Console.ReadLine();
        // int magicNumber = int.Parse(ask);
        Random randomGenerator = new();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber;

        do
        {
            Console.Write("What is your guess? ");
            // string guess = Console.ReadLine();
            // guessNumber = int.Parse(guess);
            guessNumber = int.Parse(Console.ReadLine()); //<- Simpler way to do it.


            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guessNumber != magicNumber);
    }
}