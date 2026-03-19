using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";   
        job1._startYear = 2021;
        job1._endYear = 2028;
        

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company= "Apple";
        job2._startYear = 2028;
        job2._endYear = 2035;

        Resume myresume = new Resume();

        myresume._name = "Oscar";

        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
    }
}