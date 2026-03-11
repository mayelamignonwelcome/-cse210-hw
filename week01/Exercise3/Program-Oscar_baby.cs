using System;


class Program
{
    static void Main(string[] args)
    {
        Random randomNumbe = new Random();
        int magicNumber = randomNumbe.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            String answerFromUser = Console.ReadLine();
            guess = int.Parse(answerFromUser);

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
        }
        Console.WriteLine("Congratulations! You guessed the number.");

        while (true)
        {
            Console.Write("Do you want to play again? yes ");
            String answerFromUser = Console.ReadLine().ToLower();

            if (answerFromUser == "yes")
            {
                magicNumber = randomNumbe.Next(1, 101);
                guess = -1;
                Console.WriteLine("Great! Let's play again.");
            }

            else
            {
                Console.WriteLine("Thanks for playing! Goodbye.");
                break;
            }
            
            
        }
    }
}