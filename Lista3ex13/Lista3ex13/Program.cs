using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int number;
                while (true)
                {
                    Console.Write("Digite um número não negativo para calcular o fatorial: ");
                    if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Erro: Por favor, digite um número inteiro não negativo.");
                }

                long fatorial = 1;
                for (int i = number; i > 1; i--)
                {
                    fatorial *= i;
                }

                Console.WriteLine("{0} {1}.", "O fatorial de", number);
                Console.WriteLine("{0} {1}.", "é", fatorial);

                string resposta;
                while (true)
                {
                    Console.Write("Deseja calcular outro fatorial? (S/N): ");
                    resposta = Console.ReadLine().ToUpper();
                    if (resposta == "S" || resposta == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Resposta inválida. Por favor, digite 'S' para sim ou 'N' para não.");
                }

                if (resposta == "N")
                {
                    break;
                }

            } while (true);
        }
    }
}
