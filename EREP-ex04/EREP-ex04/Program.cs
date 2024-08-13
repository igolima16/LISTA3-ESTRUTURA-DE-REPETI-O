using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            ExibirTabuada(numero);
        }

        static void ExibirTabuada(int numero)
        {
            Console.WriteLine($"Tabuada do número {numero}:");

            // Loop para gerar e exibir a tabuada do número
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
