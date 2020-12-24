using System;
using System.Globalization;

namespace uri_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double entry;

            entry = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entry >= 0 && entry <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (entry >= 25.01 && entry <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (entry >= 50.01 && entry <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (entry >= 75.01 && entry <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
