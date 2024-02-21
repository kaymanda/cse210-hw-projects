using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed)
        :base(date,length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * _length;
    }
    public override double GetSpeed()
    {
        return _speed;
    }

}