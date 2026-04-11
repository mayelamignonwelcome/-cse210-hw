using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Extra feature: Leveling system for gamification
    // Players gain levels as they accumulate points (1 level per 1000 points).
    // When leveling up, they get a bonus reward. This adds motivation and progression to the quest system.
    
    static int totalScore = 0;
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score & Level");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": ShowScoreAndLevel(); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
                case "7": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static int GetLevel()
    {
        return totalScore / 1000 + 1;
    }

    static void ShowScoreAndLevel()
    {
        int currentLevel = GetLevel();
        int nextLevelScore = currentLevel * 1000;
        int scoreToNextLevel = nextLevelScore - totalScore;
        
        Console.WriteLine($"\n=== Quest Progress ===");
        Console.WriteLine($"Level: {currentLevel}");
        Console.WriteLine($"Score: {totalScore}");
        Console.WriteLine($"Points to next level: {scoreToNextLevel}");
    }

    static void CreateGoal()
    {
        Console.WriteLine("Choose type: 1=Simple, 2=Eternal, 3=Checklist");
        string type = Console.ReadLine();
        Console.Write("Name: "); string name = Console.ReadLine();
        Console.Write("Description: "); string desc = Console.ReadLine();
        Console.Write("Points: "); int points = int.Parse(Console.ReadLine());

        if (type == "1")
            goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2")
            goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("Target count: "); int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: "); int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        
        int previousLevel = GetLevel();
        int earned = goals[index].RecordEvent();
        totalScore += earned;
        int newLevel = GetLevel();
        
        Console.WriteLine($"You earned {earned} points!");
        
        if (newLevel > previousLevel)
        {
            Console.WriteLine($"🎉 LEVEL UP! You are now level {newLevel}! 🎉");
        }
    }

    static void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i+1}. {goals[i].GetStatus()}");
    }

    static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(totalScore);
            foreach (Goal g in goals)
                sw.WriteLine(g.SaveString());
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }
        string[] lines = File.ReadAllLines("goals.txt");
        totalScore = int.Parse(lines[0]);
        goals.Clear();
        for (int i = 1; i < lines.Length; i++)
            goals.Add(Goal.LoadString(lines[i]));
        Console.WriteLine("Goals loaded!");
    }
}


