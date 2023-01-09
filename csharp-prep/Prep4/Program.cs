using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {   //create list of integers
        List<int> num = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        do
        { //keep asking for input until 0 is typed
            string input = Console.ReadLine();
            number = int.Parse(input);
            num.Add(number);
        } while (number != 0);
        //calculate aggregate functions
        int sum = num.Sum();
        int average = sum / num.Count();
        int max = num.Max();
        //console output
        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {max}.");

    }
}