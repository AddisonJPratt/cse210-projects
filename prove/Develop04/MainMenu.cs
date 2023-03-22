using System;
public class MainMenu
{

    public string OptionsDisplay()
    {
        string input = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflecting Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();
            Console.Clear();
        } while (input != "1" && input != "2" && input != "3" && input != "4");

        return input;
    }

    public Activity PickActivity(string input)
    {
        Activity activity = new Activity();

        if (input == "1")
        {
            activity = new BreathingActivity();
        }
        else if (input == "2")
        {
            activity = new ReflectingActivity();
        }

        else if (input == "3")
        {
            activity = new ListingActivity();
        }
        return activity;
    }



}