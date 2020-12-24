using System;

namespace uri_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, hf, mi, mf, inicio, fim, duracao, horas, minutos_restante;

            string[] valores = Console.ReadLine().Split(' ');

            hi = int.Parse(valores[0]);
            mi = int.Parse(valores[1]);
            hf = int.Parse(valores[2]);
            mf = int.Parse(valores[3]);

            inicio = hi * 60 + mi;

            fim = hf * 60 + mf;

            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = (24 * 60 - inicio) + fim;
            }

            horas = duracao / 60;
            minutos_restante = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos_restante + " MINUTO(S)");
        }
    }
}
