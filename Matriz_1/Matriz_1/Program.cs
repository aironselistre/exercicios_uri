using System;

namespace Matriz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo.
             * Em seguida, mostrar na tela somente os números negativos da matriz.
             * 
             * Entrada: A entrada contém os números M e N na mesma linha, depois os dados da matriz.
             * Saída: A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo. 
            */

            // Definindo tamanho da matriz
            string[] entrada = Console.ReadLine().Split(' ');

            // Guardando tamanho de linhas e colunas
            int M = int.Parse(entrada[0]);
            int N = int.Parse(entrada[1]);

            // Criando e instanciando matriz
            int[,] mat = new int[M, N];

            // Guardando valores na matriz
            for (int i=0; i<M; i++)
            {
                string[] s = Console.ReadLine().Split(' '); 
                for (int c=0; c<N; c++)
                {
                    mat[i, c] = int.Parse(s[c]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            // Identificando números negativos
            for (int i=0; i<M; i++)
            {
                for (int c=0; c<N; c++)
                {
                    if (mat[i, c] < 0)
                    {
                        Console.WriteLine(mat[i, c]);
                    }
                }
            }
 
        }
    }
}
