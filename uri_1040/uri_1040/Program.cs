using System;
using System.Globalization;

namespace uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, nota, nota_exame, media_final;

            string[] valores = Console.ReadLine().Split(' ');

            n1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

            nota = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (nota == 4.85f)
            {
                nota = 4.8f;
            }

            Console.WriteLine("Media: " + nota.ToString("F1", CultureInfo.InvariantCulture));

            if (nota >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (nota < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                nota_exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + nota_exame.ToString("F1", CultureInfo.InvariantCulture));
                media_final = (nota + nota_exame) / 2;
                if (media_final >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media_final.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
