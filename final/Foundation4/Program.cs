using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("Feburary 20, 2024", 30, 10));
        activities.Add(new Swimming("January 20, 2024", 75, 15));
        activities.Add(new Cycling("Feburary 17,2024", 45, 10));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}