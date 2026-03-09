using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        String answerFromUser = Console.ReadLine();
        int gradePercentage = int.Parse(answerFromUser);

        String letterGrade = "";
        

        if (gradePercentage >=90)
        {
            letterGrade= "A";
        }

        else if (gradePercentage >=80)
        {
            letterGrade= "B";
        }

        else if (gradePercentage >=70)

        {
            letterGrade= "c";
        }

        else if (gradePercentage >=60)
        {
            letterGrade ="D";
        }

        else

        {
            letterGrade= "F";
        }
        Console.WriteLine($"your letter grade is {letterGrade}.");

        if (gradePercentage>=70)

        {
            Console.WriteLine("Congratulations! you passed the class ");
        }

        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time! ");
        }

        int lastDigit = gradePercentage % 10;
        String signGrade = "";
    

        if (lastDigit >= 7)
            signGrade = "+";
        

        else if (lastDigit <= 3 )
            signGrade = "-";
        

        Console.WriteLine($"your letter grade is {letterGrade}{signGrade}.");
    }
}