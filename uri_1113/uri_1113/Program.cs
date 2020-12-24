using System;

namespace uri_1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                    Console.WriteLine("Crescente");
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}
