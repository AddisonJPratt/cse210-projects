using System;

class Program
{

    public void Display()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
    }
    static void Main(string[] args)
    {
        Program main = new Program();
        PromptGenerator p = new PromptGenerator();
        p.RandomPrompt();
        Console.WriteLine("Put in a journal entry question please");
        string add = Console.ReadLine();
        p.prompts.Add(add);
        p.RandomPrompt();
        main.Display();

        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("option 1");

                break;
            case 2:
                Console.WriteLine("numba 2");

                break;
            case 3:
                Console.WriteLine("numba 3");

                break;
            case 4:
                Console.WriteLine("numba 4");

                break;
            case 5:
                Console.WriteLine("numba 5");

                break;
            default:
                Console.WriteLine("ok");

                break;
        }

    }
}