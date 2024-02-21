using System;
using System.ComponentModel;

public class Event
{
  protected string _title;
  protected string _description;
  protected string _date;
  protected string _time;
  protected string _typeEvent;
  protected Address _address;

   public Event(string title, string description, string date, string time)
   {
     _title = title;
     _description = description;
     _date = date;
     _time = time;
        
   }
   public void SetAddress(string address, string city, string state)
   {
      _address = new Address(address,city,state); 
   }
   public void DisplayDetails()
   {
      Console.WriteLine();
      Console.WriteLine("---Details---");
      Console.WriteLine($"Title: {_title}");
      Console.WriteLine($"Description: {_description}");
      Console.WriteLine($"Date: {_date}");
      Console.WriteLine($"Time: {_time}");
      Console.WriteLine($"Address: {_address.GetAddress()}");
      Console.WriteLine();

   }
   public void ShortDescription()
    {
      Console.WriteLine();
      Console.WriteLine("---Description---");
      Console.WriteLine($"Type of Event: {_typeEvent}");
      Console.WriteLine($"Event: {_title}");
      Console.WriteLine($"Date: {_date}");
      Console.WriteLine();
    }
   
   //public void GetEvent()
   //{
    
   //}

}