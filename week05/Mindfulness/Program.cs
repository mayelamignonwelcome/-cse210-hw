using System;
using System.Collections.Generic;

class Program
{
    // Extra feature: session activity tracking shown at exit to exceed the base requirements.
    private static Dictionary<string, int> activityCounts = new Dictionary<string, int>
    {
        { "Breathing", 0 },
        { "Reflection", 0 },
        { "Listing", 0 }
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
                TrackActivity("Breathing");
            }
            else if (choice == "2")
            {
                ReflectionActivity r = new ReflectionActivity();
                r.Run();
                TrackActivity("Reflection");
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
                TrackActivity("Listing");
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }

        ShowSessionSummary();
    }

    static void TrackActivity(string name)
    {
        if (activityCounts.ContainsKey(name))
        {
            activityCounts[name]++;
        }
    }

    static void ShowSessionSummary()
    {
        Console.WriteLine();
        Console.WriteLine("Session summary:");
        foreach (var entry in activityCounts)
        {
            Console.WriteLine($"- {entry.Key} Activity completed {entry.Value} time(s).");
        }
        Console.WriteLine("Thank you for using the Mindfulness app!");
    }
}
