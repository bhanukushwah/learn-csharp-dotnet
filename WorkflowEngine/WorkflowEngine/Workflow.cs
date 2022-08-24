namespace WorkflowEngine
{
	public class Workflow: IWorkflow
	{
		private readonly IList<IActivity> _activities = new List<IActivity>();
		
		public void Add(IActivity activity) 
		{
			if (activity == null)
				throw new ArgumentNullException("Activity can not be null.");
            _activities.Add(activity);
		}
		
		public void Remove(IActivity activity) 
		{
			if (activity == null)
				throw new ArgumentNullException("Null activity can not be removed.");
            _activities.Remove(activity);
		}

		public IEnumerable<IActivity> GetActivities()
		{
			return _activities;
		}
	}
}