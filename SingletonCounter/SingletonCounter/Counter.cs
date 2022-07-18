using System;

namespace SingletonCounter
{
    public class Counter
    {
        private Counter() { }

        private static Counter? _instance;
        public int count = 0;
        public static Counter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Counter();
            }

            return _instance;
        }

        public void Increment()
        {
            count++;
        }
        public void Decrement()
        {
            count--;
        }
    }
}
