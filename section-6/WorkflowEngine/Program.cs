namespace WorkflowEngine;

public class Program
{
    public static void Main()
    {
        Engine e = new Engine();
        e.RegisterTask(new UploadVideo());
        e.RegisterTask(new CallApi());
        e.RegisterTask(new SendEmail());
        e.RegisterTask(new ChangeStatus());
        e.Run();
    }
}
