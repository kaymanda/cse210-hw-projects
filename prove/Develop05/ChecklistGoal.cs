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
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;

    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
        
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    } 

    public override string GetDetailsString()
    {
        string details = _shortName + "("+_description + ")" + _amountCompleted + _target;
        return details;
    }
    public override string GetStringRepresentation()
    {
        string representation = _shortName + _description + _points + _bonus + _amountCompleted + _target; 
        return representation;
    }

    
}