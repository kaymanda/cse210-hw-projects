using System;

public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public double GetPace()
    {
        return 60/GetSpeed();
    }

    public string GetSummary()
    {
        return $"{this.GetType().Name}: \n{_date} \nDistance: {GetDistance()} miles - ({_length} min) \nSpeed: {GetSpeed()} mph \nPace: {GetPace()} min per mile";
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    


}