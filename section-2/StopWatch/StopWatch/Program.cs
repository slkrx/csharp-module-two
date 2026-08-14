namespace StopWatch;

class Program()
{
    public static void Main()
    {
        StopWatch s = new StopWatch();
        try 
        {
            s.Stop();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            s.Duration();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        s.Start();
        try
        {
            s.Start();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            s.Duration();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        s.Stop();
        Console.WriteLine(s.Duration());
        s.Start();
        try
        {
            s.Duration();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        s.Stop();
        Console.WriteLine(s.Duration());
    }
}
