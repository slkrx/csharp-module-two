namespace StackOverflow;

public class Program()
{
    public static void Main()
    {
        Post p = new Post("title", "description", DateTime.Now);
        p.UpVote();
        p.UpVote();
        p.UpVote();
        p.UpVote();
        p.DownVote();
        p.DownVote();
        p.DownVote();
        p.DownVote();
        p.DownVote();
        Console.WriteLine(p.VoteValue);
        // p.VoteValue++;
    }
}
