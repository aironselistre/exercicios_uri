using System;
using System.Globalization;

namespace ExercicioVetores_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. Cada  uma  dessas  informações  deve  ser  armazenada  em  um  vetor. 
            Depois,  imprimir  os  nomes  dos  alunos  aprovados, considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.
            */

            int N;

            // Definindo quantidade de alunos
            N = int.Parse(Console.ReadLine());

            // Criando e instanciando vetores
            string[] alunos = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            // Separando valores em respectivos vetores
            for (int i=0; i<N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                alunos[i] = valores[0];
                nota1[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");

            for (int i=0; i<N; i++)
            {
                if ((nota1[i] + nota2[i]) / 2.0 >= 6.0)
                {
                    Console.WriteLine(alunos[i]);
                }
            }
        }
    }
}
