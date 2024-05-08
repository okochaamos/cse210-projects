using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        {
            DisplayWelcomeMessage();
                

            
            int userNumber = PromptUserNumber();
            int square = SquareNumber(userNumber);
            string userName = PromptUserName();
            
            DisplayResult(userName, userNumber);

            static void DisplayWelcomeMessage()
            {
                Console.WriteLine("Welcome to the program!");
            }

            

            static int PromptUserNumber()
            {
                Console.WriteLine("What is your favorite number: ");
                int userNumber = int.Parse(Console.ReadLine());
                return userNumber;

            }

            static int SquareNumber(int userNumber) 
            {
                int square = userNumber * userNumber;
                return square;
            }

            string PromptUserName()
            {
                Console.WriteLine("Please enter your name: ");
                userName = Console.ReadLine();
                return userName;
            }

            static void DisplayResult(string userName, int square)
            {
                Console.WriteLine($"{userName}, the square of the number is {square}");
            }

            
        }

        
        


    }
}