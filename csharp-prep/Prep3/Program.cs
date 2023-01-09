using System;

class Program
{
    static void Main(string[] args)
    {   // create random number generator
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 100);

        string input;
        int guess;
        //While statement that runs until you get the right number
        do
        {
            Console.WriteLine("What is the magic number?");
            input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        } while (guess != number);

    }
}