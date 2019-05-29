using System;

namespace Exercise
{
    /// <summary>
    ///     Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
    ///     provide two methods: Start and Stop.We call the start method first, and the stop method next.
    ///     Then we ask the stopwatch about the duration between start and stop.Duration should be a
    ///     value in TimeSpan.Display the duration on the console.
    ///     We should also be able to use a stopwatch multiple times.So we may start and stop it and then
    ///     start and stop it again. Make sure the duration value each time is calculated properly.
    ///     We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
    ///     start time). So the class should throw an InvalidOperationException if its started twice.
    /// </summary>
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }

        public void Start()
        {
            Console.WriteLine("Enter to start the Stopwatch!!!");
            if (string.IsNullOrEmpty(Console.ReadLine()))
            {
                Console.WriteLine("Start count time....");
                StartTime = DateTime.Now;
                while (true)
                {
                    var input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input)) continue;

                    if (input == "stop" || input == "Stop")
                    {
                        Stop();
                        break;
                    }
                }
            }
        }

        public void Stop()
        {
            EndTime = DateTime.Now;
            Duration = EndTime - StartTime;
            Console.WriteLine("{0} : {1} : {2}", Duration.Hours, Duration.Minutes, Duration.Seconds);
        }
    }
}