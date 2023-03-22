using System;

public class ListingActivity : Activity

{


    private Random _random = new Random();

    private List<string> _prompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};


    public ListingActivity()
    {
        SetActivityName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

    }


    public override void StartActivity()
    {

        DisplayPrompt();
        ListThoughts();


    }
    public override void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($"---{_prompts[_random.Next(_prompts.Count)]}---\n");
        Console.Write("You may begin in ");
        UseTimer().CountDownFrom(5);
        Console.WriteLine();

    }
    private string RandomPrompt()
    {

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string _prompt = _prompts[index];
        return _prompt;

    }

    private void ListThoughts()
    {
        DateTime futureTime = UseTimer().GetFutureTime(GetDuration());
        int items = 0;

        while (!UseTimer().TimesUp(futureTime))
        {
            Console.Write("> ");
            Console.ReadLine();
            items++;
        }

        Console.Write($"You wrote a total of {items} thoughts");
        UseTimer().LoadingScreen();
        Console.WriteLine();
    }

}

