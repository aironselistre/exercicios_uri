using System;

namespace ExercicioVetores_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde cada elemento C é a soma dos elementos correspondentes
            de A e B. Imprima o vetor C gerado.
            */

            int N;

            // Definindo tamanho do vetor
            N = int.Parse(Console.ReadLine());

            // Criando e instanciando vetorA e vetorB
            int[] vetorA = new int[N];
            int[] vetorB = new int[N];
            int[] vetorC = new int[N];

            // Valores dos vetores A e B
            string[] vetA = Console.ReadLine().Split(' ');
            string[] vetB = Console.ReadLine().Split(' ');

            // Passando valores de vetA para vetorA
            for (int i=0; i<N; i++)
            {
                vetorA[i] = int.Parse(vetA[i]);
            }
            
            // Passando valores de vetB para vetorB
            for (int i=0; i<N; i++)
            {
                vetorB[i] = int.Parse(vetB[i]);
            }
            
            // Criando vetorC
            for (int i=0; i<N; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[i];
            }

            // Printando valor do vetorC
            for (int i=0; i<N; i++)
            {
                Console.Write(vetorC[i] + " ");
            }
        }
    }
}
