using System;

namespace WorkflowEngine;

public class CallApi : ITask
{
    public void Execute()
    {
        Console.WriteLine("Calling API...");
    }
}
