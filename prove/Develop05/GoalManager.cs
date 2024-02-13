using System;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals; 
    private int _score;

    public GoalManager()    
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine($"\nYour Points : {_score}");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a chioce from the menu: ");

    }
    public void DisplayPlayerInfo()
    {
       Console.WriteLine("\nYou have" + _score + "points.");

    }
    public void ListGoalNames()
    {
        int number = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal name in _goals)
        {
            Console.WriteLine($"{number}. {name}");
            number++;
        }
    }
    public void ListGoalDetails()
    {
        int number = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal name in _goals)
        {
            Console.WriteLine($"{number}. {name.GetDetailsString()}");
            number++;
        }
        Console.WriteLine($"You have {_score} points");


    }
    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string goalPick = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a small description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points ");
        int points = int.Parse(Console.ReadLine());

        if(goalPick == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }
        else if (goalPick == "2")
        {
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }
        else if (goalPick == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal check = new ChecklistGoal(name, description, points,target, bonus);
            _goals.Add(check);
        }
        else
        {
            
            Console.WriteLine("Error. Retry.");
            
        }

    }
    public void RecordEvent()
    {
       ListGoalNames();
       Console.WriteLine("Which one of your goals did you accomplished?"); 
       int completedGoals = int.Parse(Console.ReadLine());
       _goals[completedGoals - 1].RecordEvent();
       
       _score += completedGoals;
        Console.WriteLine($"Congratulation! You've earned {completedGoals} points!");
        Console.WriteLine($"You have {_score} points now!");
    }
    public void SaveGoals()
    {
        Console.Write("What is the the name for your goal file?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        } 
    }
    public void LoadGoals()
    {
        Console.Write("What is the the name for your goal file?");
        string loadFile = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(loadFile);

        _score = int.Parse(lines.First());
        
    }
}



