using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator pq1 = new PromptGenerator();
        pq1._prompts.Add("How did I see the Lord's hand in my life today? ");
        pq1._prompts.Add("What is one thing I learned today? ");
        pq1._prompts.Add("What is one thing I am grateful for today? ");
        pq1._prompts.Add("How could I have made today better? ");
        pq1._prompts.Add("What was my overall emotions today? ");
        pq1._prompts.Add("What is one thing I want to remember that my child/children did today? ");

        Journal everyDay = new Journal();

        string pick = "";

        do{
            Console.WriteLine("Please select one of the following choices:");
            List<string> choices = new List<string> {"1. Write","2. Display", "3. Load", "4. Save", "5. Quit"};

            foreach (string choice in choices)
            {
                Console.WriteLine(choice);
            }
                pick = Console.ReadLine();

            if (pick == "1")
            {
                DateTime current = DateTime.Now;
                Entry e1 = new Entry();
                e1._promptText = pq1.GetRandomPrompt();
                e1._date = current.ToShortDateString();

                Console.Write(e1._promptText);
                e1._entryText = Console.ReadLine();
                everyDay._entries.Add(e1);
             
            }
            else if (pick == "2")
            {
                everyDay.DisplayAll();
            }
            else if (pick == "3")
            {
                Console.WriteLine("What is the name of the file? ");
                string filename = Console.ReadLine();

                everyDay._entries = everyDay.LoadFromFile(filename);

            }
            else if (pick == "4")
            {
                everyDay.SaveToFile(everyDay._entries);
            }
        } while (pick != "5");


    }
}