using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int quantidadeValores = 10;
            double[] valores = ObterValores(quantidadeValores);
            double maiorValor = ObterMaiorValor(valores);
            double soma = CalcularSoma(valores);
            double media = CalcularMedia(soma, quantidadeValores);

            
            ExibirResultados(maiorValor, soma, media);
        }

        static double[] ObterValores(int quantidade)
        {
            double[] valores = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                valores[i] = ObterValorPositivo(i + 1);
            }

            return valores;
        }

        static double ObterValorPositivo(int indice)
        {
            double valor;
            while (true)
            {
                Console.Write($"Digite o {indice}º valor positivo: ");
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

        static void ExibirResultados(double maiorValor, double soma, double media)
        {
            Console.WriteLine($"Maior valor inserido: {maiorValor}");
            Console.WriteLine($"Soma dos valores: {soma}");
            Console.WriteLine($"Média aritmética dos valores: {media}");
        
        }
    }
}
