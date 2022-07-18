using System;

namespace SingletonCounter;
public class Program
{
   public static void Main(string[] args)
    {
        Counter counter = Counter.GetInstance();
        Counter counter2 = Counter.GetInstance();
        Counter counter3 = Counter.GetInstance();

        counter.Increment();
        counter.Increment();
        counter.Increment();

        counter2.Increment();
        counter2.Increment();

        counter3.Decrement();

        Console.WriteLine("counter: " + counter.count);
        Console.WriteLine("counter2: " + counter2.count);
        Console.WriteLine("counter3: " + counter3.count);

        if (counter == counter2 && counter2 == counter3)
        {
            Console.WriteLine("Singleton works, as all variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, as all contain different instances.");
        }
    }
}

