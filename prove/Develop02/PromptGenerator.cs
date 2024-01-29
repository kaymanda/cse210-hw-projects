using System;
using System.IO;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
       
        
            
        public string GetRandomPrompt()
        {
            Random randomPrompt = new Random();
            int questionPrompt = randomPrompt.Next(0,_prompts.Count());

            string question = _prompts[questionPrompt];

            return question;
        }
}