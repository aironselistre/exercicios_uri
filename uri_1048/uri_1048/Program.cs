using System;
using System.Globalization;

namespace uri_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novo_salario, reajuste, percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                percentual = 15.00;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12.00;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10.00;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7.00;
            }
            else
            {
                percentual = 4.00;
            }

            reajuste = salario * percentual / 100;  
            novo_salario = salario + reajuste;
            

            Console.WriteLine("Novo salario: " + novo_salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}
