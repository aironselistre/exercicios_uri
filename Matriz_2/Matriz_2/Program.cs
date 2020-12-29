using System;

namespace Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos elementos de cada linha da matriz. 
             * 
             * Entrada:
             * A entrada contém números representando a soma dos elementos de cada linha da matriz.
             * 
             * Saída:
             * A saída contém os números representando a soma dos elementos de cada linha da matriz.
            */

            // Definindo tamanho matriz
            int N = int.Parse(Console.ReadLine());

            // Criando e instanciando matriz
            int[,] mat = new int[N, N];

            // Lendo e guardando valores na matriz
            for (int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int c=0; c<N; c++)
                {
                    mat[i, c] = int.Parse(s[c]);
                }
            }

            // Soma dos elementos de cada linha da matriz
            int[] soma = new int[N];

            for (int i=0; i<N; i++)
            {
                for (int c=0; c<N; c++)
                {
                    soma[i] += mat[i, c];
                }
                Console.WriteLine(soma[i]);
            }
        }
    }
}
