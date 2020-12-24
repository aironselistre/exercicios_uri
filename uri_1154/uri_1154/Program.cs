using System;
using System.Globalization;

namespace uri_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, denominador = 0, soma = 0;
            double media;

            idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade >= 0)
            {
                denominador = denominador += 1;
                soma += idade;
                idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            media = (double)soma / denominador;
            Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
