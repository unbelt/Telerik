using System;
using System.Text;
using System.Timers;
// 7. Using delegates write a class Timer that has can execute certain method at each t seconds.

class Timer
{
    public static void Main()
    {
        Console.WriteLine("Events: ");
        System.Timers.Timer timer = new System.Timers.Timer();
        timer.Elapsed += timer_Elapsed; // Add a method to the timer
        timer.Interval = 3000; // Invoke a method every 3 sec.
        timer.Enabled = true;
        Console.ReadLine();
    }

    static void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        // Print exact time when event is raised
        Console.WriteLine("Event started at {0}", e.SignalTime);
    }
}