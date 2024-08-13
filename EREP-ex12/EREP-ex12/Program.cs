using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // Obtém a quantidade de valores do usuário
                int quantidadeValores = ObterQuantidadeValores();

                // Obtém os valores e realiza os cálculos
                (double maiorValor, double menorValor, double soma, double media, double porcentagemPositivos, double porcentagemNegativos) = ProcessarValores(quantidadeValores);

                // Exibe os resultados
                ExibirResultados(maiorValor, menorValor, soma, media, porcentagemPositivos, porcentagemNegativos);

                // Pergunta ao usuário se deseja executar o programa novamente
            } while (DesejaContinuar());
        }

        static int ObterQuantidadeValores()
        {
            int quantidadeValores;
            while (true)
            {
                Console.Write("Digite a quantidade de valores (N) (positiva, mas menor que vinte): ");
                if (int.TryParse(Console.ReadLine(), out quantidadeValores) && quantidadeValores > 0 && quantidadeValores < 20)
                {
                    return quantidadeValores;
                }
                else
                {
                    Console.WriteLine("Quantidade inválida. Por favor, digite um valor positivo, mas menor que vinte.");
                }
            }
        }

        static (double maiorValor, double menorValor, double soma, double media, double porcentagemPositivos, double porcentagemNegativos) ProcessarValores(int quantidade)
        {
            double maiorValor = double.MinValue;
            double menorValor = double.MaxValue;
            double soma = 0;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < quantidade; i++)
            {
                double valor = ObterValor(i + 1);

                // Atualiza o maior e menor valor
                if (valor > maiorValor) maiorValor = valor;
                if (valor < menorValor) menorValor = valor;

                // Soma os valores e conta positivos e negativos
                soma += valor;
                if (valor > 0) positivos++;
                if (valor < 0) negativos++;
            }

            double media = soma / quantidade;
            double porcentagemPositivos = CalcularPorcentagem(positivos, quantidade);
            double porcentagemNegativos = CalcularPorcentagem(negativos, quantidade);

            return (maiorValor, menorValor, soma, media, porcentagemPositivos, porcentagemNegativos);
        }

        static double ObterValor(int indice)
        {
            double valor;
            while (true)
            {
                Console.Write($"Digite o {indice}º valor: ");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número.");
                }
            }
        }

        static double CalcularPorcentagem(int quantidade, int total)
        {
            return (double)quantidade / total * 100;
        }

        static void ExibirResultados(double maiorValor, double menorValor, double soma, double media, double porcentagemPositivos, double porcentagemNegativos)
        {
            Console.WriteLine($"Maior valor inserido: {maiorValor}");
            Console.WriteLine($"Menor valor inserido: {menorValor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética dos valores: {media}");
            Console.WriteLine($"Porcentagem de valores positivos: {porcentagemPositivos:F2}%");
            Console.WriteLine($"Porcentagem de valores negativos: {porcentagemNegativos:F2}%");
        }

        static bool DesejaContinuar()
        {
            while (true)
            {
                Console.Write("Deseja executar o programa novamente? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "S") return true;
                if (resposta == "N") return false;

                Console.WriteLine("Resposta inválida. Por favor, digite 'S' para sim ou 'N' para não.");
            }
        }
    }
}
