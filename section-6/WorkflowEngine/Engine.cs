using System;

namespace WorkflowEngine;

public class Engine
{
    private readonly List<ITask> _tasks = [];
    
    public void Run()
    {
        foreach (ITask task in _tasks)
            task.Execute();
    }
    
    public void RegisterTask(ITask task)
    {
        _tasks.Add(task);
    }
}
