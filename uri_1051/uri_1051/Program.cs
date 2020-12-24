using System;
using System.Globalization;

namespace uri_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, faixaIR1, faixaIR2, faixaIR3, imposto1, imposto2, imposto3, IR;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario < 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 4500.00)
            {
                faixaIR1 = salario - 4500.00;
                imposto1 = faixaIR1 * 0.28;
                faixaIR2 = salario - faixaIR1 - 3000.00;
                imposto2 = faixaIR2 * 0.18;
                faixaIR3 = salario - faixaIR1 - faixaIR2 - 2000.00;
                imposto3 = faixaIR3 * 0.08;
                IR = imposto1 + imposto2 + imposto3;
                Console.WriteLine("R$ " + IR.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 3000.01)
            {
                faixaIR2 = salario - 3000.00;
                imposto2 = faixaIR2 * 0.18;
                faixaIR3 = salario - faixaIR2 - 2000.00;
                imposto3 = faixaIR3 * 0.08;
                IR = imposto2 + imposto3;
                Console.WriteLine("R$ " + IR.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 2000.01)
            {
                faixaIR3 = salario - 2000.00;
                imposto3 = faixaIR3 * 0.08;
                Console.WriteLine("R$ " + imposto3.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
