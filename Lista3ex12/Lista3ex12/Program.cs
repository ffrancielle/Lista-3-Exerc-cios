using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            do
            {
                int N = 0;
                int maior = 0;
                int menor = 0;
                int soma = 0;
                int positivos = 0;
                int negativos = 0;
                int numero = 0;

                while (true)
                {
                    Console.Write("Digite a quantidade de valores (positivo e menor que 20): ");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out N) && N > 0 && N < 20)
                    {
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
                    while (true)
                    {
                        Console.Write("Digite o valor {0}: ", i + 1);
                        string entrada = Console.ReadLine();

                        if (int.TryParse(entrada, out numero))
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

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
                        }
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

                while (true)
                {
                    Console.Write("Deseja executar o programa novamente? (S/N): ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == "S" || resposta == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Responda com 'S' para sim ou 'N' para não.");
                    }
                }

            } while (resposta == "S");
        }
    }
}
