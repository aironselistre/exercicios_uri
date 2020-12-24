using System;

namespace uri_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor && valor <= 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
