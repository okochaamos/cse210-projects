using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine($"What is the magic number? {number}");

        

        int answer = -1;
        

        while(answer != number)
        {
            Console.Write($"What is your guess? ");
            string myGuess = Console.ReadLine();
            answer = int.Parse(myGuess);

            if(answer < number)
            {
                Console.WriteLine("Higher");

            }
            else if(answer > number)
            {
                Console.WriteLine("Lower");

            }
            else
            {
                Console.WriteLine("You guessed it. ");
            

            }

        }
    }
}