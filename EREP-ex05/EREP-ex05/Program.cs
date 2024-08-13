using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = ObterValorPositivo();

            // Exibe a tabuada do valor inserido no intervalo de 1 a 10
            ExibirTabuada(valor);
        }

        static double ObterValorPositivo()
        {
            double valor;

            while (true)
            {
                Console.Write("Digite um valor positivo: ");
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                }
            }
        }

        static void ExibirTabuada(double valor)
        {
            Console.WriteLine($"Tabuada do número {valor}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{valor} x {i} = {valor * i}");
            }
        }
    }
}
