using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite o segundo valor: ");
                b = int.Parse(Console.ReadLine());

                if (b <= a)
                {
                    Console.WriteLine("O segundo valor deve ser maior que o primeiro. Digite novamente: ");

                }
            } while (b <= a);

            Console.WriteLine("Valores digitados:");
            Console.WriteLine("Primeiro valor: {0}", a);
            Console.WriteLine("Segundo valor: {0}", b);

        }
    }
}
