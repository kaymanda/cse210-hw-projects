using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        GoalManager goalGame = new GoalManager();

        while (playAgain)
        {
            goalGame.Start();
            
            string pick = Console.ReadLine();
            if (pick == "1")
            {
                goalGame.CreateGoal();
            }
            else if (pick == "2")
            {
                goalGame.ListGoalDetails();
            }
            else if (pick == "3")
            {
                goalGame.SaveGoals();
            }
            else if (pick == "4")
            {
                goalGame.LoadGoals();
            }
            else if (pick == "5")
            {
                goalGame.RecordEvent();
            }
            else if (pick == "6")
            {
                Console.Clear();
                Console.WriteLine("This is the End!");
                playAgain = false;
            }
        }
    }
}