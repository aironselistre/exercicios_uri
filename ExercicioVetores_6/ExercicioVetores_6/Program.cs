using System;

namespace ExercicioVetores_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome da pessoa mais velha.
            */

            int N, maisVelho = 0;
            string pessoaMaisVelha = "PrimeiroNome";

            // Definindo o número de pessoas
            N = int.Parse(Console.ReadLine());

            // Criando a instanciando vetor nome e idade
            string[] nome = new string[N];
            int[] idade = new int[N];

            // Criando e instanciando vetor pessoas
            string[] pessoas = new string[2];

            // Adicionando valores aos vetores nome e idade
            for (int i=0; i<N; i++)
            {
                pessoas = Console.ReadLine().Split(' ');
                nome[i] = pessoas[0];
                idade[i] = int.Parse(pessoas[1]);
            }

            // Identificando pessoa mais velha
            for (int i=0; i<N; i++)
            {
                if (idade[i] > maisVelho)
                {
                    maisVelho = idade[i];
                    pessoaMaisVelha = nome[i];
                }
            }

            // Printando pessoa mais velha
            Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha);

        }
    }
}
