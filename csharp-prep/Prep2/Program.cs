using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in percentage? ");
        string myGrade = Console.ReadLine();

        int myScore = int.Parse(myGrade);
        string letter = "";

        if(myScore >= 90)
        {
            letter = "A";

        }

        else if(myScore >= 80)
        {
            letter = "B";


        }

        else if(myScore >= 70)
        {
            letter = "C";
        }

        else if(myScore >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is : {letter}");


        if(myScore >= 70 || myScore >= 80 || myScore >= 90)
        {
            Console.Write("Congratulations!!!! You Passed. ");

        }

        else
        {
            Console.WriteLine("Put more effort next time. ");
        }

    }
}