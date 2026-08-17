using System;

namespace DBMS;

public abstract class DbConnection
{
    private string connectionString_;
    private TimeSpan timeout_;
    
    public DbConnection(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new InvalidDataException("Connection string cannot be null or empty.");
        this.connectionString_ = connectionString;
        this.timeout_ = TimeSpan.FromMinutes(30);
    }
    
    public abstract void OpenConnection();
    public abstract void CloseConnection();
}
