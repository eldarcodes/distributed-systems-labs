using System;
using System.Threading;

namespace program
{
    class PriorityTesting
    {
        static long[] counts;
        static bool finish;
        static void ThreadFunc(object iThread)
        {
            while (true)
            {
                if (finish)
                    break;
                counts[(int)iThread]++;
            }
        }
        static void Main()
        {
            counts = new long[5];
            Thread[] t = new Thread[5];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = new Thread(ThreadFunc);
                t[i].Priority = (ThreadPriority)i;
            }
            for (int i = 0; i < t.Length; i++)
                t[i].Start(i);

            Thread.Sleep(10000);

            finish = true;

            for (int i = 0; i < t.Length; i++)
                t[i].Join();
            for (int i = 0; i < t.Length; i++)
                Console.WriteLine("Thread with priority {0, 15}, Counts: {0} ", (ThreadPriority)i, counts[i]);
        }
    }

}
