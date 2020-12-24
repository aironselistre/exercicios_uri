using System;
using System.Globalization;

namespace uri_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double valor1, valor2, valor3, mediaPonderada;

            N = int.Parse(Console.ReadLine());

            for (int i=0; i<N; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                valor1 = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(entrada[2], CultureInfo.InvariantCulture);
                mediaPonderada = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;
                Console.WriteLine(mediaPonderada.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
