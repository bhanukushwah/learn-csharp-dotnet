namespace Polymorphism
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				SqlConnection connection = new SqlConnection("", new TimeSpan(0,0,10));
				connection.Open();
			    connection.Close();

				OracleConnection oracleConnection = new OracleConnection("", new TimeSpan(0, 0, 10));
                oracleConnection.Open();
                oracleConnection.Close();
            }
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}