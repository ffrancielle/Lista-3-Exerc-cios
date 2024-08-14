using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex7
{
    internal class Program
    {
        static void Main()
        {
            int valor = 1;
            int multiplicador;
            int resultado;

            while (valor <= 20)
            {
                Console.WriteLine("Tabuada do número {0}:", valor);

                multiplicador = 1;
                while (multiplicador <= 10)
                {
                    resultado = valor * multiplicador;
                    Console.WriteLine("{0} x {1} = {2}", valor, multiplicador, resultado);
                    multiplicador++;
                }

                Console.WriteLine("Pressione qualquer tecla para ver a próxima tabuada...");
                Console.ReadKey();

                valor++;
            }

            Console.WriteLine("Fim das tabuadas.");
        }
    
    }
}
