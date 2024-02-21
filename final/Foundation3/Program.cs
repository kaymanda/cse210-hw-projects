using System;

class Program
{
    static void Main(string[] args)
    {
        //First Event Reception
        Reception rec = new Reception("Wallace and Susan Devito","What a Joyous Union","October 21, 2024","7:00pm","2lovebirds@live.com");
        
        rec.SetAddress("3713 S Jenny Dr", "Riverton", "Utah");
        rec.DisplayDetails();
        rec.Display();
        rec.ShortDescription();
        
        Console.WriteLine();

        //Second Event Outdoor
        Outdoor outdoor = new Outdoor("Summer Party", "We are having a Summer Party, welcome the sun!", "June 21, 2024", "4:00pm-11:00pm","Sunny at 75 degrees");
        
        outdoor.SetAddress("1000 N Main St", "Tooele", "Utah");
        outdoor.DisplayDetails();
        outdoor.Display();
        outdoor.ShortDescription();

        Console.WriteLine();

        //Third Event Lecture
        Lecture lec = new Lecture("Learning about Voice Acting","Voice Acting Q&A", "April 3, 2024", "12:00pm-2:00pm", "Crispin Freemen", 75);
        
        lec.SetAddress("4000 W 1928 S", "Idaho Falls", "Idaho");
        lec.DisplayDetails();
        lec.Display();
        lec.ShortDescription();

    }
}