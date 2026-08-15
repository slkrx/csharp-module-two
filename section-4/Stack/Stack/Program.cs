namespace Stack;

public class Program()
{
    public static void Main()
    {
        Stack s = new Stack();
        // s.Push(null);
        s.Push(1);
        s.Push("hello");
        s.Push(DateTime.Now);
        s.Push(10);
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
    }
}
