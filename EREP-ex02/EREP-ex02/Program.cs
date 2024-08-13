using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double primeiroValor = ObterValorPositivo("Digite o primeiro valor (valor positivo): ");
                double segundoValor = ObterSegundoValorMaior(primeiroValor);

                // Exibe os valores válidos inseridos
                Console.WriteLine($"Primeiro valor: {primeiroValor}");
                Console.WriteLine($"Segundo valor: {segundoValor}");
            }

                double ObterValorPositivo(string mensagem)
            {
                double valor;

                while (true)
                {
                    Console.Write(mensagem);
                    if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
                }

                return valor;
            }

                double ObterSegundoValorMaior(double primeiroValor)
            {
                double segundoValor;

                while (true)
                {
                    Console.Write("Digite o segundo valor (deve ser maior que o primeiro valor): ");
                    if (double.TryParse(Console.ReadLine(), out segundoValor) && segundoValor > primeiroValor)
                    {
                        break;
                    }
                    Console.WriteLine("Valor inválido. O segundo valor deve ser maior que o primeiro valor.");
                }

                return segundoValor;

                
            }
        }
    }
}
