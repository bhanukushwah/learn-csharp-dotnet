namespace Polymorphism
{
    public abstract class DbConnection
	{
		private readonly string _connectionString;
		private readonly TimeSpan _timeout;

		public DbConnection(string connectionString, TimeSpan timeout)
		{
			if(connectionString == null)
				throw new ArgumentNullException(nameof(connectionString));
			this._connectionString = connectionString;
			this._timeout = timeout;
		}

		public abstract void Open();
		public abstract void Close();
	}
}