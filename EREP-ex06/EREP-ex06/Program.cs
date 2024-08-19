using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorX = ObterValorPositivo();

            int intervaloA = ObterValorInteiro("Digite o valor inicial do intervalo (A): ");
            int intervaloB = ObterIntervaloMaiorQueA(intervaloA);


            ExibirTabuadaDecrescente(valorX, intervaloA, intervaloB);
        }

        static double ObterValorPositivo()
        {
            double valor;

            while (true)
            {
                Console.Write("Digite um valor positivo (X): ");
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

        static int ObterValorInteiro(string mensagem)
        {
            int valor;

            while (true)
            {
                Console.Write(mensagem);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
                }
            }
        }

        static int ObterIntervaloMaiorQueA(int intervaloA)
        {
            int intervaloB;

            while (true)
            {
                Console.Write("Digite o valor final do intervalo (B - deve ser maior que A): ");
                if (int.TryParse(Console.ReadLine(), out intervaloB) && intervaloB > intervaloA)
                {
                    return intervaloB;
                }
                else
                {
                    Console.WriteLine("Valor inválido. O valor final do intervalo (B) deve ser maior que o valor inicial (A).");
                }
            }
        }

        static void ExibirTabuadaDecrescente(double valorX, int intervaloA, int intervaloB)
        {
            Console.WriteLine($"Tabuada do número {valorX} no intervalo de {intervaloB} para {intervaloA}:");

            for (int i = intervaloB; i >= intervaloA; i--)
            {
                Console.WriteLine($"{valorX} x {i} = {valorX * i}");
            }
        }
    }
}
