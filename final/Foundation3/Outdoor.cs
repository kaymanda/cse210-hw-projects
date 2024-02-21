using System;

public class Outdoor : Event
{
    private string _statement;

    public Outdoor(string title, string description, string date, string time,string statement)
        :base(title,description,date,time)
    {
        _typeEvent = "Outdoor";
        _statement = statement;
    }
    public void Display()
    {
        Console.WriteLine($"Type of Event: {_typeEvent}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"Weather: {_statement}");
        
    }
}