using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
         List<int> numbers = new List<int>();

        int NumberOfNumbers = -1;
        while (NumberOfNumbers != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            String answerFromUser = Console.ReadLine();
            NumberOfNumbers = int.Parse(answerFromUser);
            if (NumberOfNumbers != 0)
            {
                numbers.Add(NumberOfNumbers);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum is: {max}");
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
    }
}