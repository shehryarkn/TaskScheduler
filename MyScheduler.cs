using System;

public static class MyScheduler
{
    public static void IntervalInSeconds(int hour, int sec, double interval, Action task)
    {
        interval = interval/3600;
        SchedulerService.Instance.ScheduleTask(hour, sec, interval, task);
    }

    public static void IntervalInMinutes(int hour, int min, double interval, Action task)
    {
        interval = interval/60;
        SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
    }

    public static void IntervalInHours(int hour, int min, double interval, Action task)
    {
        SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
    }

    public static void IntervalInDays(int hour, int min, double interval, Action task)
    {
        interval = interval * 24;
        SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
    }
}