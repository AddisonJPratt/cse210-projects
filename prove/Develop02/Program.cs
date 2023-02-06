using System;

public partial class Program
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
        Journal journal = new Journal();
        int option = 0;

        while (option != 5)
        {
            main.Display();

            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:

                    Entry entry1 = new Entry();
                    entry1.addPrompt();
                    Console.WriteLine(entry1.Prompt);
                    entry1.Text = Console.ReadLine();
                    int length = entry1.Text.Length;

                    if (length >= 50)
                    {
                        entry1.Date = DateTime.Now.ToShortDateString();
                        journal.Entries.Add(entry1);
                    }
                    else
                    {
                        Console.WriteLine("Please don't be lazy and write more in your Journal! Try again");
                        Console.WriteLine("");
                        Console.WriteLine(entry1.Prompt);
                        entry1.Text = Console.ReadLine();
                    }


                    Console.WriteLine("");
                    break;

                case 2:
                    journal.ShowAll();

                    break;
                case 3:
                    Console.WriteLine("What is the name of the file that you want to load?");
                    journal.file = Console.ReadLine();
                    journal.loadFile();

                    break;
                case 4:
                    Console.WriteLine("Please enter the name of the file that you want to save to.");
                    journal.newFileName = Console.ReadLine();
                    journal.saveFile();
                    Console.WriteLine("Saved file");

                    break;
                case 5:
                    Console.WriteLine("Enjoy your day!");

                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");

                    break;
            }
        }

    }
}