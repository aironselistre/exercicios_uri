using System;
using System.Globalization;

namespace ExercicioVetores_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos elementos. Depois mostrar todos os elementos
             * do vetor que estejam abaixo da média.
            */

            int N;
            double media, soma = 0;

            // Definindo tamanho do vetor
            N = int.Parse(Console.ReadLine());

            // Criando e instanciando vetor
            double[] valores = new double[N];

            // Separando valores do vetor
            string[] vet = Console.ReadLine().Split(' ');

            // Adicionando valores do vetor vet para o vetor valores
            for (int i=0; i<N; i++)
            {
                valores[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            // Somando valores
            for (int i=0; i<N; i++)
            {
                soma += valores[i];
            }

            // Média aritmética
            double resultado = soma / N;

            // Printando resultado
            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));

            // Evidenciando valores menores que a média
            for (int i=0; i<N; i++)
            {
                if (valores[i] < resultado)
                {
                    Console.WriteLine(valores[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
