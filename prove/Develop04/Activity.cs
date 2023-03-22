using System;
public class Activity
{

    private string _activityName;
    private string _description;
    private int _duration;
    private Time _timer = new Time();

    public Activity()
    {

    }

    public virtual void DisplayPrompt() { }
    public virtual void StartActivity() { }

    public void SetActivityName(string activityName)
    {

        _activityName = activityName;
    }

    public string GetActivityName()
    {

        return _activityName;
    }

    public void SetDescription(string description)
    {
        _description = description;

    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }



    public void ActivitySetup()
    {

        Console.Write($"Welcome to the {_activityName}.\n");
        _timer.LoadingScreen();
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = Int32.Parse(Console.ReadLine());

        Console.Clear();

        Console.Write("Get ready...");
        _timer.CountDownFrom(4);
        Console.Clear();
        Thread.Sleep(500);





    }


    public void FinishActivity()
    {

        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have finished another {_duration} seconds of the {_activityName}");
        _timer.LoadingScreen();

        Console.Clear();

    }
    public Time UseTimer()
    {

        return _timer;
    }

    // public void SetLoadingTime(int loadingTime)
    // {

    //     _loadingTime = loadingTime;
    // }

}