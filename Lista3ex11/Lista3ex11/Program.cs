using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int maior = 0;
            int menor = 0;
            int soma = 0;
            int positivos = 0;
            int negativos = 0;
            int numero = 0;
            string entrada = "";

            while (true)
            {
                Console.Write("Digite a quantidade de valores (positivo e menor que 20): ");
                entrada = Console.ReadLine();

                numero = 0;
                int i = 0;
                while (i < entrada.Length)
                {
                    char caractere = entrada[i];
                    if (caractere < '0' || caractere > '9')
                    {
                        numero = -1;
                        break;
                    }
                    numero = numero * 10 + (caractere - '0');
                    i++;
                }

                if (numero > 0 && numero < 20)
                {
                    N = numero;
                    break;
                }
                else
                {
                    Console.WriteLine("Erro: O valor deve ser positivo e menor que 20.");
                }
            }

            menor = int.MaxValue;

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite o valor {0}: ", i + 1);
                entrada = Console.ReadLine();

                numero = 0;
                int j = 0;
                while (j < entrada.Length)
                {
                    char caractere = entrada[j];
                    if (caractere < '0' || caractere > '9')
                    {
                        numero = int.MinValue;
                        break;
                    }
                    numero = numero * 10 + (caractere - '0');
                    j++;
                }

                if (entrada[0] == '-' && numero != int.MinValue)
                {
                    numero = -numero;
                }

                if (numero != int.MinValue)
                {
                    soma += numero;

                    if (i == 0 || numero > maior)
                    {
                        maior = numero;
                    }

                    if (i == 0 || numero < menor)
                    {
                        menor = numero;
                    }

                    if (numero > 0)
                    {
                        positivos++;
                    }
                    else if (numero < 0)
                    {
                        negativos++;
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Valor inválido.");
                    i--;
                }
            }

            double media = soma / (double)N;
            double porcentagemPositivos = (positivos / (double)N) * 100;
            double porcentagemNegativos = (negativos / (double)N) * 100;

            Console.WriteLine("Maior valor: {0}", maior);
            Console.WriteLine("Menor valor: {0}", menor);
            Console.WriteLine("Soma dos valores: {0}", soma);
            Console.WriteLine("Média aritmética dos valores: {0:F2}", media);
            Console.WriteLine("Porcentagem de valores positivos: {0:F2}%", porcentagemPositivos);
            Console.WriteLine("Porcentagem de valores negativos: {0:F2}%", porcentagemNegativos);
        }
    }
}
