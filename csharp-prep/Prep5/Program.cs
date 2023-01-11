using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int n = PromptUserNumber();
        int squared = SquaredNumber(n);
        Console.WriteLine($"{name}, the square of your number is {squared}");


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");

    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        string num = Console.ReadLine();
        int n = int.Parse(num);
        return n;
    }

    static int SquaredNumber(int n)
    {
        int squared = n * n;
        return squared;
    }
}