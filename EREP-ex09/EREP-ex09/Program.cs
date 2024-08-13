using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 30;
            ExibirFibonacci(quantidade);
        }

        static void ExibirFibonacci(int quantidade)
        {
            // Inicializa os dois primeiros números da série de Fibonacci
            int num1 = 1;
            int num2 = 1;

            Console.WriteLine($"Os primeiros {quantidade} valores da série de Fibonacci:");

            // Loop para calcular e exibir os valores da série de Fibonacci
            for (int i = 0; i < quantidade; i++)
            {
                // Exibe o número atual da série
                Console.WriteLine(num1);

                // Calcula o próximo número da série somando os dois últimos números
                int proximoNumero = num1 + num2;

                // Atualiza os dois últimos números para os próximos cálculos
                num1 = num2;
                num2 = proximoNumero;
            }
        }
    }
}
