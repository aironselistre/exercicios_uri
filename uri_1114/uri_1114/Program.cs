using System;

namespace uri_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int tentativa;

            tentativa = int.Parse(Console.ReadLine());

            while (tentativa != 2002)
            {
                Console.WriteLine("Senha Invalida");
                tentativa = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
