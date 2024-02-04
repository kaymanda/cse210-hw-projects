using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);

        Console.WriteLine("Get Ready....");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(3);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);

        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spins = new List<string>();
        spins.Add("|");
        spins.Add("/");
        spins.Add("-");
        spins.Add("\\");
        spins.Add("|");
        spins.Add("/");
        spins.Add("-");
        spins.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string sp = spins[i];
            Console.Write(sp);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spins.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }

}