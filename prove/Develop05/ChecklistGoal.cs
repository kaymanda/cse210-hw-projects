using System;
using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int  _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name,description, points)
    {

    }
    public  void RecordEvent()
    {
        
    }
    public   bool IsComplete()
    {
        return false;
    } 

    public string GetDetailsString()
    {
        return "";
    }
    public  string GetStringRepresentation()
    {
        return "";
    }

    
}