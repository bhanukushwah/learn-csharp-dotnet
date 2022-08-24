namespace WorkflowEngine
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var engine = new WorkflowEngine();
			
			IWorkflow workflow = new Workflow();

			workflow.Add(new UploadVideoToCloud());
			workflow.Add(new SendMail());;

			engine.Run(workflow);
		}
	}
}