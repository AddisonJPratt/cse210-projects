using System;
using System.Threading;
using System.Collections.Generic;

public class Time
{
    public Time()
    {

    }
    public void LoadingScreen()
    {

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }

    }

    public void CountDownFrom(int num)
    {

        for (int i = num; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }

    public DateTime GetFutureTime(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        return futureTime;
    }

    public bool TimesUp(DateTime futureTime)
    {

        DateTime currentTime = DateTime.Now;

        if (currentTime > futureTime)
        {
            return true;

        }
        return false;
    }

}