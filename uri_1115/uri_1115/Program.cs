using System;

namespace uri_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] valores = Console.ReadLine().Split(' ');

            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }
            }
        }
    }
}
