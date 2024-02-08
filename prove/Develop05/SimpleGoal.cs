using System;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points, bool isComplete)
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
    public string GetStringRepresentation()
    {
        return "";
    }

}