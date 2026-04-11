using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartMessage();
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            elapsed += 3;

            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsed += 3;
        }

        EndMessage();
    }
}
