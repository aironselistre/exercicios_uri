using System;
using System.Globalization;
using System.IO;

namespace teste_estrutura_repetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            // Programa para calcular a média de idade

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont = 0;
            soma = 0.00;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (cont == 0)
            {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                media = soma / cont;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
