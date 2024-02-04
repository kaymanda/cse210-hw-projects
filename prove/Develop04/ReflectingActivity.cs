using System;
using System.Reflection.Metadata.Ecma335;

public class ReflectingActivity:Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name = "Reflecting Activity", string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", int duration = 6, string prompts = "", string questions ="")
        :base(name,description,duration)
    {
        
        

    }
     public void Run() 
    {
        DisplayStartingMessage();
        
        AddPrompts();

        Console.Clear();
        AddQuestions();

        Console.WriteLine("Consider the following prompt: ");
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");

        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.WriteLine("");
            Console.Write("You may begin.....");
            ShowCountDown(5);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                DisplayQuestions();
                ShowSpinner(4);
            }

            DisplayEndingMessage();
            ShowSpinner(5);
        }
    }
    public List<string> AddPrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        return _prompts;
    }
    public List<string> AddQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was completed?");
        _questions.Add("What made this time diiferent than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");


        return _questions;
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(0,_prompts.Count)];
        _prompts.Remove(prompt);

        return prompt;
    }
    public string GetRandomQuestion()
    {
        Random questionPick = new Random();
        string quest = _questions[questionPick.Next(0, _questions.Count)];
        _questions.Remove(quest);

        return quest;
    }
    public void DisplayPrompt()
    {
        string reflect = GetRandomPrompt();
        Console.WriteLine($"---{reflect}---");

    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"{question}");
        
    }
}