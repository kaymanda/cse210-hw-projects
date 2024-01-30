using System;

public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, string prompts)
        :base(name,description,duration)
    {
        
    }
     public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        
            return _prompts ;
    }

}