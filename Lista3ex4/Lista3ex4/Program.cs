using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex4
{
    internal class Program
    {
        static void Main()
        {
            int numero = 5;
            int i;


            Console.WriteLine("Tabuada do número {0}:", numero);
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }
        }
    }
}
