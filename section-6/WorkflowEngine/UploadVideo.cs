using System;

namespace WorkflowEngine;

public class UploadVideo : ITask
{
    public void Execute()
    {
        Console.WriteLine("Uploading video...");
    }
}
