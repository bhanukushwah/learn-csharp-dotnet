namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string  connectionString, TimeSpan timeout): base(connectionString, timeout) 
        {

        }
        public override void Open()
        {
            Console.WriteLine("SqlConnection opens a new connection!");
        }
        public override void Close()
        {
            Console.WriteLine("SqlConnection connection closed!");
        }
    }
}