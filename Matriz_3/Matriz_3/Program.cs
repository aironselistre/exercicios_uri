using System;

namespace Matriz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. Suponha não haver empates.
             * 
             * Entrada:
             * A entrada contém um número N, depois os dados da matriz.
             * 
             * Saída:
             * A saída contém os números representando o maior elemento de cada linha da matriz.
            */

            // Definido tamanho NxN matriz
            int N = int.Parse(Console.ReadLine());

            // Criando e instanciando matriz
            int[,] mat = new int[N, N];

            // Inserindo valores matriz
            for (int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int c=0; c<N; c++)
                {
                    mat[i, c] = int.Parse(s[c]);
                }

            }

            // Descobrindo maior valor de cada linha
            for (int i=0; i<N; i++)
            {
                int maiorValor = 0;
                for (int c=0; c<N; c++)
                {
                    if (mat[i,c] > maiorValor)
                    {
                        maiorValor = mat[i, c];
                    }
                }
                Console.WriteLine(maiorValor);
            }
        }
    }
}
