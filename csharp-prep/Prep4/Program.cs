using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int numberEntered = -1;
        while (numberEntered != 0)
        {
            Console.Write("Enter number: ");

            string  userInput = Console.ReadLine();
            numberEntered = int.Parse(userInput);

            if ( numberEntered != 0)
            {
                numbers.Add(numberEntered);
            }
        }

        //Compute the sum, or total, of the numbers in the list.

        int sum = 0; 
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average of the numbers in the list.

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the maximum, or largest, number in the list.

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}