using System;
using System.Collections;

namespace Stack;

public class Stack
{
    private readonly List<object> list_;
    
    public Stack()
    {
        list_ = new List<object>();
    }
    
    public void Push(object o)
    {
        list_.Add(o);
    }
    
    public object Pop()
    {
        object o = list_[^1];
        list_.Remove(o);
        return o;
    }
}
