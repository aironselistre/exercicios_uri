using System;
using System.Globalization;

namespace uri_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int produto, alcool = 0, gasolina = 0, diesel = 0;

            produto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (produto != 4)
            {
                if (produto >= 1 && produto <= 3)
                {
                    if (produto == 1)
                    {
                        alcool += 1;
                        produto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    if (produto == 2)
                    {
                        gasolina += 1;
                        produto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    if (produto == 3)
                    {
                        diesel += 1;
                        produto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                }
                else
                    produto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
