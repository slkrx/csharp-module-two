namespace DBMS;

public class Program()
{
    public static void Main()
    {
        // try 
        // {
        //     DbConnection conn = new SqlConnection(null);
        // }
        // catch (InvalidDataException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        SqlConnection sql = new SqlConnection("sql connection");
        OracleConnection oracle = new OracleConnection("oracle connection");
        DbCommand sqlCommand = new DbCommand(sql, "select * from people;");
        sqlCommand.Execute();
        DbCommand oracleCommand = new DbCommand(oracle, "select * from people;");
        oracleCommand.Execute();
    }
}
