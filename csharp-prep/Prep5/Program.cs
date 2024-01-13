using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string usersName = PromptUserName();
        int usersNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(usersNumber);

        DisplayResult(usersName, squaredNumber);   
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to this program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string yourName = Console.ReadLine();

        return yourName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int yourNumber = int.Parse(Console.ReadLine());

        return yourNumber;
    }

    static int SquareNumber(int yourNumber)
    {
        int squared = yourNumber * yourNumber;

        return squared;
    }

    static void DisplayResult(string yourName, int squared)
    {
        Console.WriteLine($"{yourName}, the square of your number is {squared}");
    }
}