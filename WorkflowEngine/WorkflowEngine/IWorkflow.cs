namespace WorkflowEngine
{
    public interface IWorkflow
	{
		public void Add(IActivity activity);
		public void Remove(IActivity activity);
		IEnumerable<IActivity> GetActivities();
	}
}