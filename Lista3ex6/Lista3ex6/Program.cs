using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int A = 0;
            int B = 0;

            while (valor <= 0)
            {
                Console.Write("Digite um valor positivo: ");
                int.TryParse(Console.ReadLine(), out valor);

                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número positivo.");
                }
            }

            Console.Write("Digite o valor de A (inicial do intervalo): ");
            int.TryParse(Console.ReadLine(), out A);

            while (true)
            {
                Console.Write("Digite o valor de B (final do intervalo): ");
                int.TryParse(Console.ReadLine(), out B);

                if (B > A)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("O valor de B deve ser maior que o valor de A. Por favor, digite novamente o valor de B.");
                }
            }

            Console.WriteLine("Tabuada do número {0} no intervalo de {1} a {2}:", valor, B, A);
            for (int i = B; i >= A; i--)
            {
                Console.WriteLine("{0} x {1} = {2}", valor, i, valor * i);
            }
        }
    }
}
