using System;
using System.Globalization;

namespace uri_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int valores, soma = 0, soma_impar = 0;

            valores = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (valores != 0)
            {
                if (valores % 2 == 0)
                {
                    soma = valores + (valores + 2) + (valores + 4) + (valores + 6) + (valores + 8);
                    Console.WriteLine(soma);
                    valores = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else
                {
                    soma_impar = valores + 1;
                    soma = soma_impar + (soma_impar + 2) + (soma_impar + 4) + (soma_impar + 6) + (soma_impar + 8);
                    Console.WriteLine(soma);
                    valores = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
