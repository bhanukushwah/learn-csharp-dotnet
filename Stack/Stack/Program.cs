namespace Stack
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{

			Stack stack = new Stack();

			stack.Push(3);
			stack.Push(2);
			stack.Push(1);
			stack.Push(0);
			stack.Push(null);

			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());

			} catch(Exception e)
			{
				Console.WriteLine(e);
			}

		}
	}
}