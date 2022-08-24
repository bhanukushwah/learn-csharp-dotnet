namespace Stopwatch
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			Task.Delay(3000).Wait();
            stopwatch.Start();

			TimeSpan duration = stopwatch.GetDuration();
			Console.WriteLine("Duration : " +duration);

			} catch(Exception e)
			{
				Console.WriteLine("Error :" +e);
			}		
        }
	}
}