using System;

namespace Matriz_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            // leitura dos dados
            for (int i=0; i<M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int c=0; c<N; c++)
                {
                    mat[i, c] = int.Parse(valores[c]);
                }
            }

            // Definindo fila que vai girar
            int fila = int.Parse(Console.ReadLine());

            // Matriz comeca na linha 0, necessário decrementar o valor da fila
            fila -= 1;

            // Salvar o último da fila
            int ultimoDaFila = mat[fila, N - 1];

            // Movendo todos da fila da direita para a esquerda em forma decrescente (menos o último)
            for (int c = N - 1; c > 0; c--)
            {
                mat[fila, c] = mat[fila, c - 1];
            }

            // Colocando o último da fila na primeira posição
            mat[fila, 0] = ultimoDaFila;

            // Printando resultado
            for (int i=0; i<M; i++)
            {
                for (int c=0; c<N; c++)
                {
                    Console.Write(mat[i, c] + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
