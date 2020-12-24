using System;

namespace uri_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorMaior = int.Parse(Console.ReadLine());
            int posicao = 1;

            for (int i=2; i<=100; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor > valorMaior)
                {
                    valorMaior = valor;
                    posicao = i;
                }
            }
            Console.WriteLine(valorMaior);
            Console.WriteLine(posicao);
        }
    }
}
