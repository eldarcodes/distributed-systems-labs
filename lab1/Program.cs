using System;
using System.Threading;

namespace program
{
    class Program
    {
        static long Factorial(long n)
        {
            long res = 1;
            do
            {
                res = res * n;
            } while (--n > 0);
            return res;
        }
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                int i_copy = i;
                Thread t = new Thread(() => Console.Write("ABCDEFGHIJK"[i_copy]));
                t.Start();
            }

        }

    }

}
