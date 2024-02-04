using System;

public class ListingActivity:Activity
{
    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity(string name = "Listing Activity", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", int duration = 60 , int count = 0, string prompts ="")
        :base(name,description,duration)
    {
        _prompts = new List<string>();
    }  
    public void Run()
    {
        DisplayStartingMessage();
        //int runTime = int.Parse(Console.ReadLine());
        
        AddPrompts();
        //Console.WriteLine("Get Ready.....");
        //ShowSpinner(8);
        Console.WriteLine(GetRandomPrompt());

        ShowSpinner(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("List as many responses you can to the given prompt: ");
        
        Console.Write("You may begin in.....");

        //ShowCountDown(5);
        
        while (startTime < endTime)
        {
            GetListFromUser();
            _count++;
            startTime = DateTime.Now;   
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        
    }
    public List<string> AddPrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of your?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of the personal heroes?");

        return _prompts;
    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        string givenPrompt = _prompts[random.Next(0, _prompts.Count)];
        _prompts.Remove(givenPrompt);
    
        return givenPrompt;
    }
    public List<string> GetListFromUser()
    {
        List<string> listing = new List<string>();
        string input = Console.ReadLine();
        listing.Add(input);
        
        return listing;
    }
}