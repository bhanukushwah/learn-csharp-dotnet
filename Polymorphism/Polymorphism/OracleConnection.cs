namespace Polymorphism
{
    public class OracleConnection: DbConnection
	{
        public OracleConnection(string connectionString, TimeSpan timeout): base(connectionString, timeout)
        {

        }
        public override void Open()
        {
            Console.WriteLine("OracleConnection opens a new connection!");
        }
        public override void Close()
        {
            Console.WriteLine("OracleConnection connection closed!");
        }
    }
}