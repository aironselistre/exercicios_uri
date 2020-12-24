using System;

namespace uri_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double resultado;

            N = int.Parse(Console.ReadLine());

            for (int i=1; i<=N; i++)
            {
                if (N >= 5 && N <= 2000)
                {
                    if (i % 2 == 0)
                    {
                        resultado = Math.Pow(i, 2);
                        Console.WriteLine(i+"^2" + " = "+ resultado);
                    }
                }
            }
        }
    }
}
