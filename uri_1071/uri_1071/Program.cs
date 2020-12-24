using System;

namespace uri_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                max = y;
                min = x;
            }
            else
            {
                max = x;
                min = y;
            }

            int soma = 0;
            for (int i=min+1; i<max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
