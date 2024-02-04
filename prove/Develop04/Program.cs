using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        
        while(choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathe = new BreathingActivity();
                breathe.Run();
    
            
            }
            else if (choice == "2")
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }    
            else if (choice == "3")
            {
                ListingActivity list = new ListingActivity();
                list.Run();
                
            }
            else 
            {
                Console.WriteLine();
            }
            
        }
    }
}
