using System;
using System.IO;
public class PromptGenerator
{
    public List<string> _prompts;
       
        public PromptGenerator() 
        {
             
            
                //"How did I see the Lord's hand in my life today?",
                //"What is one thing I learned today?",
                //"What is one thing I am grateful for today?",
                //"How could I have made today better?",
                //"What was my overall emotions today?",
                //"What is one thing I want to remember that my child/children did today?"
            
        }
        
         

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int questionPrompt = randomPrompt.Next(_prompts.Count);
        return _prompts[questionPrompt];
    }
}