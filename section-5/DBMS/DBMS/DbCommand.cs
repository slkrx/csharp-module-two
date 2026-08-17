using System;

namespace DBMS;

public class DbCommand
{
    private DbConnection conn_;
    private string instruction_;
    
    public DbCommand(DbConnection conn, string instruction)
    {
        if (conn == null)
            throw new InvalidDataException("DbConnection cannot be null.");
        if (string.IsNullOrWhiteSpace(instruction))
            throw new InvalidDataException("Instruction cannot be null.");
        conn_ = conn;
        instruction_ = instruction;
    }
    
    public void Execute()
    {
        conn_.OpenConnection();
        Console.WriteLine(instruction_);
        conn_.CloseConnection();
    }
}
