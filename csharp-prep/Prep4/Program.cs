using System;

class Program
{
    static void Main(string[] args)
    {
       
        List<int> myList = new List<int>();

        Console.WriteLine("Enter number : ");
        int myNumbers = int.Parse(Console.ReadLine());

        myList.Add(myNumbers);

        while(myNumbers != 0)
        {
            Console.WriteLine("Enter number : ");
            myNumbers = int.Parse(Console.ReadLine());

            myList.Add(myNumbers);            
        }

        
        foreach(int item in myList)
            {
                Console.WriteLine(item);

                
            }

        int itemNumbers = myList.Count;

        Console.WriteLine(itemNumbers);

        int appearance = itemNumbers - 1;

        Console.WriteLine(appearance);

        int sum = 0;


        for(int x = 0; x < itemNumbers; x++)
        {
            
            Console.WriteLine(x);

            sum += myList[x];
            Console.WriteLine($"The sum is : {sum}");
            
            
        }
        

        int myAverage = sum / appearance;

        Console.WriteLine($"The average is : {myAverage}");

        int max = myList[0];

        foreach(int special in myList)
        {
            if (special > max)
            {
                max = special;
            }
            Console.WriteLine($"The maximum number is : {max}");

        
        }
    }
}