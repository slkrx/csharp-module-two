using System;

namespace WorkflowEngine;

public class SendEmail : ITask
{
    public void Execute()
    {
        Console.WriteLine("Sending email...");
    }
}
