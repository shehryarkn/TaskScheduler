using System;

namespace TaskScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Interval in Seconds 
            // This Scheduler will start at 11:10 and call after every 15 Seconds
            // IntervalInSeconds(start_hour, start_minute, seconds)
            MyScheduler.IntervalInSeconds(11, 10, 15,
            () => {

                Console.WriteLine("//here write the code that you want to schedule");
            });

            // For Interval in Minutes 
            // This Scheduler will start at 22:00 and call after every 30 Minutes
            // IntervalInSeconds(start_hour, start_minute, minutes)
            MyScheduler.IntervalInMinutes(22, 00, 30,
            () => {

                Console.WriteLine("//here write the code that you want to schedule");
            });

            // For Interval in Hours 
            // This Scheduler will start at 9:44 and call after every 1 Hour
            // IntervalInSeconds(start_hour, start_minute, hours)
            MyScheduler.IntervalInHours(9, 44, 1,
            () => {

                Console.WriteLine("//here write the code that you want to schedule");
            });

            // For Interval in Seconds 
            // This Scheduler will start at 17:22 and call after every 3 Days
            // IntervalInSeconds(start_hour, start_minute, days)
            MyScheduler.IntervalInDays(17, 22, 3,
            () => {

                Console.WriteLine("//here write the code that you want to schedule");
            });

            Console.ReadLine();
        }
    }
}
