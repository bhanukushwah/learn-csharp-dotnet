using System;

namespace SingletonCounter
{
    public class Counter
    {
        private Counter() { }

        private static Counter? _instance;
        public int count = 0;
        public static Counter GetCounter()
        {
            if (_instance == null)
            {
                _instance = new Counter();
            }

            return _instance;
        }

        public void increment()
        {
            count++;
        }
        public void decrement()
        {
            count--;
        }
    }
}
