using System;

public class ReflectingActivity : Activity
{
    private Random _random = new Random();
    private List<string> _promptList = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};

    private List<string> _questionList = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"};
    public ReflectingActivity()
    {
        SetActivityName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public override void StartActivity()
    {
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in ");
        UseTimer().CountDownFrom(5);
        Questions();



    }

    public override void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"---{_promptList[_random.Next(_promptList.Count)]}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

    }
    private string RandomPrompt()
    {

        Random random = new Random();
        int index = random.Next(_promptList.Count);
        string _prompt = _promptList[index];
        return _prompt;

    }

    private void Questions()
    {
        int numQuestions = (GetDuration() / 10) + 1;

        for (int i = 0; i < numQuestions; i++)
        {
            Console.Write(">" + _questionList[_random.Next(_questionList.Count)]);
            UseTimer().LoadingScreen();
            Console.WriteLine();

        }
    }
}