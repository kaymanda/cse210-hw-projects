using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
     : base(name,description,points)
     {

     } 
     public  void RecordEvent()
    {
        
    }
    public  bool IsComplete()
    {
        return false;
    } 
    public  string GetStringRepresentation()
    {
        return "";
    }
}