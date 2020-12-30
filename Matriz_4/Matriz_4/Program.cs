using System;

namespace Matriz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima da diagonal principal.
             * Entrada:
             * A entrada contém o valor N, depois os dados da matriz.
             * Saída:
             * A saída contém a soma dos elementos da diagonal principal 
            */

            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i=0; i<N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int c=0; c<N; c++)
                {
                    mat[i, c] = int.Parse(valores[c]);
                }
            }

            // Soma dos elementos da diagonal principal
            int soma = 0;
            for (int i = 0; i<N; i++)
            {
                for (int c=i+1; c<N; c++)
                {
                    soma += mat[i, c];
                }
            }
            Console.WriteLine(soma);
        }
    }
}
