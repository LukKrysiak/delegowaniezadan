using System;

public class TimeFormatter
{
    public static string FormatTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remainingSeconds = seconds % 60;

        string formattedTime = $"{hours:D2}:{minutes:D2}:{remainingSeconds:D2}";
        return formattedTime;
    }

    public static void Main(string[] args)
    {
        int seconds = 332;
        string formattedTime = FormatTime(seconds);
        Console.WriteLine(formattedTime);
    }
}