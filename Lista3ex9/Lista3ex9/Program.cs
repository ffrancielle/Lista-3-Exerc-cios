using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anterior = 0;
            int atual = 1;
            int proximo;
            int contador = 1;

            Console.WriteLine("Série de Fibonacci - 30 primeiros valores:");

            while (contador <= 30)
            {
                Console.WriteLine("{0}: {1}", contador, atual);

                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;

                contador++;
            }
        }
    }
}
