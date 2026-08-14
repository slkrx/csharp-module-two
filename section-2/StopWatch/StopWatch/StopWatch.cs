using System;

namespace StopWatch;

public class StopWatch
{
    private DateTime? StartTimeStamp { get; set; }
    private DateTime? StopTimeStamp { get; set; }
    private bool Running { get; set; }
    
    public StopWatch()
    {
        Running = false;
    }

    public void Start()
    {
        if (Running)
            throw new InvalidOperationException("The stopwatch is already running");
        Running = true;
        StartTimeStamp = DateTime.Now;
    }
    
    public void Stop()
    {
        if (!Running)
            throw new InvalidOperationException("The stopwatch is not running");
        Running = false;
        StopTimeStamp = DateTime.Now;
    }
    
    public TimeSpan Duration()
    {
        if (StartTimeStamp == null || StopTimeStamp == null)
            throw new InvalidOperationException("Not enough data to calculate duration");
        if (Running)
            throw new InvalidOperationException("Cannot get duration while stopwatch is still running");
        return (TimeSpan)(StopTimeStamp - StartTimeStamp);
    }
}
