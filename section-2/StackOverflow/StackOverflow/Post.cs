using System;

namespace StackOverflow;

public class Post
{
    public string Title { get; }
    public string Description { get; }
    public DateTime Created { get; }
    public int VoteValue { get; private set; }
    
    public Post(string title, string description, DateTime created)
    {
        Title = title;
        Description = description;
        Created = created;
    }
    
    public void UpVote()
    {
        VoteValue++;
    }
    
    public void DownVote()
    {
        VoteValue--;
    }
}
