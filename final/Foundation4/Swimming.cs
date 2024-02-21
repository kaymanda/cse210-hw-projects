using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps)
        :base(date,length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (double)_laps*50/1000*0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance()/_length*60;
    }

}