﻿using System;

namespace uri_1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i=1; i<=10; i++)
            {
                int multiplicacao = i * N;
                Console.WriteLine(i + " x " + N + " = " + multiplicacao);
            }
        }
    }
}
