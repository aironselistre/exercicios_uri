using System;
using System.Globalization;

namespace ExercicioVetores_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tem-se um conjunto de dados contendo altura e o sexo (M e F) de N pessoas. Fazer um programa que calcule e escreva:
             * - a maior e a menor altura do grupo
             * - a média de altura das mulheres
             * - o número de homens
            */

            int N;
            double maiorAltura = 0.0;
            double menorAltura;
            double somaAlturaMulheres = 0.0;
            int numeroDeHomens = 0;
            int denominador = 0;

            N = int.Parse(Console.ReadLine());

            // Criando e instanciando vetores altura e genero
            double[] altura = new double[N];
            string[] genero = new string[N];

            // Colocando valores nos respectivos vetores
            for (int i=0; i<N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
                genero[i] = vet[1];
            }

            // Descobrindo maior altura
            for (int i=0; i<N; i++)
            {
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }

            // Descobrindo menor altura
            menorAltura = altura[0];

            for (int i=0; i<N; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }

            // Somando altura mulheres
            for (int i=0; i<N; i++)
            {
                if (genero[i] == "F")
                {
                    somaAlturaMulheres += altura[i];
                    denominador += 1; 
                }
            }

            // Descobrindo número de homens
            for (int i=0; i<N; i++)
            {
                if (genero[i] == "M")
                {
                    numeroDeHomens += 1;
                }
            }

            // Descobrindo média altura mulheres
            double media = somaAlturaMulheres / denominador;

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media de alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Número de homens = " + numeroDeHomens);
        }
    }
}
