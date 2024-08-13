using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeValores = ObterQuantidadeValores();
            double[] valores = ObterValores(quantidadeValores);

            double maiorValor = ObterMaiorValor(valores);
            double menorValor = ObterMenorValor(valores);
            double soma = CalcularSoma(valores);
            double media = CalcularMedia(soma, quantidadeValores);
            (int positivos, int negativos) = ContarPositivosENegativos(valores);
            double porcentagemPositivos = CalcularPorcentagem(positivos, quantidadeValores);
            double porcentagemNegativos = CalcularPorcentagem(negativos, quantidadeValores);

            ExibirResultados(maiorValor, menorValor, soma, media, porcentagemPositivos, porcentagemNegativos);
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

        static double[] ObterValores(int quantidade)
        {
            double[] valores = new double[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                valores[i] = ObterValor(i + 1);
            }
            return valores;
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

        static double ObterMaiorValor(double[] valores)
        {
            double maiorValor = double.MinValue;
            foreach (double valor in valores)
            {
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }
            return maiorValor;
        }

        static double ObterMenorValor(double[] valores)
        {
            double menorValor = double.MaxValue;
            foreach (double valor in valores)
            {
                if (valor < menorValor)
                {
                    menorValor = valor;
                }
            }
            return menorValor;
        }

        static double CalcularSoma(double[] valores)
        {
            double soma = 0;
            foreach (double valor in valores)
            {
                soma += valor;
            }
            return soma;
        }

        static double CalcularMedia(double soma, int quantidade)
        {
            return soma / quantidade;
        }

        static (int positivos, int negativos) ContarPositivosENegativos(double[] valores)
        {
            int positivos = 0;
            int negativos = 0;

            foreach (double valor in valores)
            {
                if (valor > 0)
                {
                    positivos++;
                }
                else if (valor < 0)
                {
                    negativos++;
                }
            }

            return (positivos, negativos);
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
    
    }
}
