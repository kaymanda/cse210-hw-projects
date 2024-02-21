using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string speaker, int capacity)
    :base(title,description,date,time)
    {
        _typeEvent = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public void Display()
    {
        Console.WriteLine($"Type of Event: {_typeEvent}\n Speaker:{_speaker} - Capacity:{_capacity}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }
}