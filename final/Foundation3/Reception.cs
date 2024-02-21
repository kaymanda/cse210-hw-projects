using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string email)
        :base(title,description,date,time)
    {
        _typeEvent = "Reception";
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void Display()
    {
        Console.WriteLine($"Type of Event: {_typeEvent}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
        Console.WriteLine($"RSVP email: {GetEmail()}"); 
    }


}