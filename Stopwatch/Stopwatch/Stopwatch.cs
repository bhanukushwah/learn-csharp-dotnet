namespace Stopwatch
{
	class Stopwatch
	{
		private bool IsRunning = false;
		private DateTime StartTime;
		private DateTime EndTime;

		public void Start()
		{
			if (IsRunning)
			{
				throw new InvalidOperationException("Stopwatch already running!");
			}
			this.IsRunning = true;
            this.StartTime = DateTime.Now;
            Console.WriteLine("StartTime : " + StartTime);
        }

		public void Stop()
		{
            if (!IsRunning)
            {
                throw new InvalidOperationException("Start Stopwatch before stopping it!");
            }
            this.IsRunning = false;
            this.EndTime = DateTime.Now;
            Console.WriteLine("EndTime : " + EndTime);
        }

        public TimeSpan GetDuration()
		{
			return EndTime - StartTime;
		}
	}
}