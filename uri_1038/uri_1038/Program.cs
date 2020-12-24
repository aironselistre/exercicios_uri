using System;
using System.Globalization;

namespace uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double codigo, quantidade, torrada_simples, xbacon, cachorro_quente, xsalada, refrigerante, total;

            string[] valores = Console.ReadLine().Split(' ');

            codigo = double.Parse(valores[0], CultureInfo.InvariantCulture);
            quantidade = double.Parse(valores[1], CultureInfo.InvariantCulture);

            cachorro_quente = 4.00;
            xsalada = 4.50;
            xbacon = 5.00;
            torrada_simples = 2.00;
            refrigerante = 1.50;

            if (codigo == 1.00)
            {
                total = cachorro_quente * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else if (codigo == 2.00)
            {
                total = xsalada * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else if (codigo == 3.00)
            {
                total = xbacon * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else if (codigo == 4.00)
            {
                total = torrada_simples * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            else if (codigo == 5.00)
            {
                total = refrigerante * quantidade;
                Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
