using System;

namespace uri_1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i=1; i < 10000; i++)
            {
                if (N < 10000)
                {
                    if (i % N == 2)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        }
    }
}
