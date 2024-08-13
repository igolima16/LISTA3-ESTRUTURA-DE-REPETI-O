using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = SomarNumeros(1, 100);
            ExibirResultado(soma);
        }

        static int SomarNumeros(int inicio, int fim)
        {
            int soma = 0;

            
            for (int i = inicio; i <= fim; i++)
            {
                soma += i;
            }

            return soma;
        }

        static void ExibirResultado(int soma)
        {
            
            Console.WriteLine($"A soma dos números inteiros positivos de 1 a 100 é: {soma}");
        }
    }
}
