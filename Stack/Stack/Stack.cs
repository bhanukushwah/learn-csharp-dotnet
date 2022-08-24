namespace Stack
{
    public class Stack
	{
		public List<object> _stack = new List<Object>();

		public void Push(object obj)
		{
			if (obj == null)
				throw new InvalidOperationException("Please provide a valid value!");
			_stack.Add(obj);
		}

		public object Pop()
		{
			if (_stack.Count == 0)	
				throw new InvalidOperationException("Stack is alreay empty.");
			object obj = _stack[^1];
			_stack.RemoveAt(_stack.Count-1);
            return obj;
		}

		public void Clear()
		{
			_stack.Clear();
		}
	}
}