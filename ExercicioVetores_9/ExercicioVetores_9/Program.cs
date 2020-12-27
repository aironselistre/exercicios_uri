using System;
using System.Globalization;

namespace ExercicioVetores_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa.
            Para isto, mandou digitar um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas.
            Fazer um programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
            - lucro < 10%
            - 10% ≤ lucro ≤ 20%
            - lucro > 20%
            
            Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.
            */

            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] compra = new double[N];
            double[] venda = new double[N];

            // Adicionando valores a cada vetor
            for (int i=0; i<N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                compra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            // Descobrindo quantidade para cada faixa e lucro de cada produto
            int abaixoDe10 = 0;
            int entre10E20 = 0;
            int acimaDe20 = 0;

            for (int i=0; i<N; i++)
            {
                double lucro = venda[i] - compra[i];
                double porcentagemLucro = lucro / compra[i] * 100.0;

                if (porcentagemLucro < 10.0)
                {
                    abaixoDe10++;
                }

                else if (porcentagemLucro <= 20.0)
                {
                    entre10E20++;
                }

                else
                {
                    acimaDe20++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + abaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre10E20);
            Console.WriteLine("Lucro acima de 20%: " + acimaDe20);

            // Descobrindo valor total de compra e venda
            double totalCompra = 0.0;
            double totalVenda = 0.0;
            double totalLucro = 0.0;

            for (int i=0; i<N; i++)
            {
                totalCompra += compra[i];
                totalVenda += venda[i];
            }

            totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: R$ " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: R$ " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: R$ " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
