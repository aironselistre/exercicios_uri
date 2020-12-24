using System;

namespace uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, final, dia, duracao;

            string[] valores = Console.ReadLine().Split(' ');

            inicio = int.Parse(valores[0]);
            final = int.Parse(valores[1]);

            dia = 24;
            
            duracao = (dia - inicio) + (final - dia);

            if (inicio >= final)
            {
                duracao = (dia - inicio) + final;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else
            {
                duracao = final - inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
        }
    }
}
