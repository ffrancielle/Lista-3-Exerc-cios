using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;

            do
            {
                Console.Write("Digite o sexo da pessoa (F para feminino, M para masculino): ");
                sexo = Console.ReadLine().ToUpper();

                if (sexo != "F" && sexo != "M")
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite 'F' para feminino ou 'M' para masculino.");
                }
            } while (sexo != "F" && sexo != "M");

            Console.WriteLine("Sexo válido registrado: {0}", sexo);

        }
    }
}
