using System;

namespace Vetores_2
{
    class Program
    {
        static void Main(string[] args)

        /*
         *Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
         - Todos os números pares
         - A quantidade de números pares
        */

        {
            int N, soma = 0;

            N = int.Parse(Console.ReadLine());

            // Criando e instanciando vetor
            int[] valores = new int[N];

            // Valores do vetor
            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                // Armazenando valores do vetor
                valores[i] = int.Parse(vet[i]);
                // Condição valores pares
                if (valores[i] % 2 == 0)
                {
                    // Printando valores pares
                    Console.Write(valores[i] + " ");
                    soma = soma + 1;
                }
            }
            // Printando soma dos valores pares
            Console.WriteLine(" ");
            Console.WriteLine(soma);

        }
    }
}
