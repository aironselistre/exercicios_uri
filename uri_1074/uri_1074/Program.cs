using System;

namespace uri_1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, valor;
            string positivo = "POSITIVE", negativo = "NEGATIVE", par = "EVEN", impar = "ODD";

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor >= Math.Pow(-10, 7) && valor <= Math.Pow(10, 7))
                {
                    if (valor % 2 == 0)
                    {
                        if (valor > 0)
                        {
                            Console.WriteLine(par + " " + positivo);
                        }
                        else if (valor < 0)
                        {
                            Console.WriteLine(par + " " + negativo);
                        }
                    }
                    if (valor % 2 != 0)
                    {
                        if (valor > 0)
                        {
                            Console.WriteLine(impar + " " + positivo);
                        }
                        else if (valor < 0)
                        {
                            Console.WriteLine(impar + " " + negativo);
                        }
                    }
                    else if (valor == 0)
                    {
                        Console.WriteLine("NULL");
                    }
                }
            }
        }
    }
}

