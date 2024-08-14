using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int maior = 0;
            int valor;
            int i = 0;

            while (i < 10)
            {
                Console.Write("Digite um valor positivo ({0}/10): ", i + 1);
                string entrada = Console.ReadLine();

                int numero = 0;
                int j = 0;

                while (j < entrada.Length)
                {
                    char caractere = entrada[j];
                    if (caractere < '0' || caractere > '9')
                    {
                        numero = -1;
                        break;
                    }
                    numero = numero * 10 + (caractere - '0');
                    j++;
                }

                if (numero > 0)
                {
                    valor = numero;
                    soma += valor;

                    if (valor > maior)
                    {
                        maior = valor;
                    }

                    i++;
                }
                else
                {
                    Console.WriteLine("Erro: Digite um valor positivo.");
                }
            }

            double media = soma / 10.0;

            Console.WriteLine("Maior valor: {0}", maior);
            Console.WriteLine("Soma dos valores: {0}", soma);
            Console.WriteLine("Média aritmética dos valores: {0:F2}", media);
        }
    }
    
}
