using System;

public class BreathingActivity:Activity
{
    public BreathingActivity(string name = "Breathing Activity", string description ="This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", int duration = 10)
        :base(name,description,duration)
    {
        //Console.WriteLine($"{name}");
        //Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void Run()
    {
        DisplayStartingMessage();
       
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //Console.WriteLine("Get Ready....");
        
        ShowSpinner(5);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe In.....");
            ShowCountDown(2);
            Console.Write("\nBreathe Out.....");
            ShowCountDown(3);
            Console.Write("\nBreathe In.....");
            ShowCountDown(4);
            Console.Write("\nBreathe Out.....");
            ShowCountDown(5);
        }

            DisplayEndingMessage();

            ShowSpinner(5);



    }
    
}