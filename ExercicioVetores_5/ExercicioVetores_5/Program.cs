using System;
using System.Globalization;

namespace ExercicioVetores_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente dos números pares lidos. 
            */

            int N, soma = 0, denominador = 0;
            double media;

            // Definingo tamanho do vetor
            N = int.Parse(Console.ReadLine());

            // Criando e instanciando vetor
            int[] valores = new int[N];

            // Separando valores do vetor
            string[] vet = Console.ReadLine().Split(' ');

            // Adicionando valores do vetor vet para valores
            for (int i=0; i<N; i++)
            {
                valores[i] = int.Parse(vet[i]);
            }

            // Somando valores pares
            for (int i=0; i<N; i++)
            {
                if (valores[i] % 2 == 0)
                {
                    soma += valores[i];
                    denominador += 1;
                }
            }

            // Média aritmética valores pares
            media = soma / denominador;

            // Printando resultado
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
