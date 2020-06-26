using System;
using System.Diagnostics;

namespace Algoritms
{
    public class TimeResult
    {
        public void GetTimeResult (Stopwatch stopwatch)
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00}.{3:00}",
                stopwatch.Elapsed.Hours,
                stopwatch.Elapsed.Minutes,
                stopwatch.Elapsed.Seconds,
                stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}