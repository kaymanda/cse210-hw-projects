using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        //add random generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;
        
        //while loop
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Yay! You guessed it!");
            }
        }
    }
}