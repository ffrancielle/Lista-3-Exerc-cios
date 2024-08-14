using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int numero = 1;

            while (numero <= 100)
            {
                soma += numero;
                numero++;
            }

            Console.WriteLine("A soma dos números inteiros de 1 a 100 é: {0}", soma);
        }
    }
}
