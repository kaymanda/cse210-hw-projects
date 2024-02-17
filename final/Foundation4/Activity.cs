using System;

public class Activity
{
    private string _date;
    private int _length;

    public Activity()
    {

    }
    public string GetSummary()
    {
        return "";
    }
    public virtual double GetDistance()
    {
        return 0;
    }


}