using System;

namespace Matriz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler duas matrizesde números inteiros A e B, contendode M linhas e N colunas cada.
             * Depois, gerar uma terceira matriz C onde cada elemento desta é a soma dos elementos correspondentes das matrizes originais.
             * Imprimir na tela a matriz gerada.
             * 
             * Entrada:
             * A entrada contém os valores de M e N, depois os valores da primeira matriz A, depois os valores da segunda matriz B, conforme exemplo.
             * 
             * Saída:
             * A saída contém os valores da matriz gerada C.
            */

            // Definindo tamanho da matriz
            string[] tamanho = Console.ReadLine().Split(' ');

            int M = int.Parse(tamanho[0]);
            int N = int.Parse(tamanho[1]);

            // Criando e instanciando matriz
            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            // Inserindo valores na matriz A
            for (int i=0; i<M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int c=0; c<N; c++)
                {
                    A[i, c] = int.Parse(valores[c]);
                }
            }

            // Inserindo valores na matriz B
            for (int i=0; i<M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int c=0; c<N; c++)
                {
                    B[i, c] = int.Parse(valores[c]);
                }
            }

            // Inserindo a soma dos valores da matriz A e B na matriz C
            for (int i=0; i<M; i++)
            {
                for (int c=0; c<N; c++)
                {
                    C[i, c] = A[i, c] + B[i, c];
                }
            }

            // Printando resultado
            for (int i=0; i<M; i++)
            {
                for (int c=0; c<N; c++)
                {
                    Console.Write(C[i, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
