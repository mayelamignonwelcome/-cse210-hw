using System;

class Program
{
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
            }
            else if (choice == "2")
            {
                ReflectionActivity r = new ReflectionActivity();
                r.Run();
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
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
    }
}
