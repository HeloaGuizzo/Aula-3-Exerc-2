using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int maior = 0;

            Console.WriteLine("----- DETERMINAR O MAIOR VALOR -----");

            Console.WriteLine("Informe o 1 valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;

            Console.WriteLine("Informe o 2 valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
            }

            Console.WriteLine("Informe o 3 valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
            }

            Console.WriteLine(" O maior valor informado é " + (maior));


        }
    }
}
