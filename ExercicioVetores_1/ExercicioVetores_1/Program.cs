using System;
using System.Globalization;

namespace ExercicioVetores_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa que leia N números reais e armazene-os em um vetor.
             * Em seguida, mostrar na tela o maior número do vetor (supor não haver empates). Mostrar também a posição do maior elemento.
            */

            int N, posicao = 0;
            double maior = 0;
            double[] valores;

            // Lendo N valores para definir tamanho do vetor
            N = int.Parse(Console.ReadLine());

            // Instanciando vetor
            valores = new double[N];

            // Lendo valores do vetor
            string[] vet = Console.ReadLine().Split(' ');

            // Armazenando valores no vetor
            for (int i=0; i<N; i++)
            {
                valores[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);

                // Maior valor e posição
                if (valores[i] > maior)
                {
                    maior = valores[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);

        }
    }
}
