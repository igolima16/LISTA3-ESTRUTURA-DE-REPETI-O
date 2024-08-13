using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREP_ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo = ObterSexo();

            // Exibe o sexo válido inserido
            Console.WriteLine($"Sexo inserido: {sexo}");
        }

        static string ObterSexo()
        {
            string sexo;

            while (true)
            {
                Console.Write("Digite o sexo (F para feminino, M para masculino): ");
                sexo = Console.ReadLine().Trim().ToUpper();

                if (sexo == "F" || sexo == "M")
                {
                    return sexo;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite 'F' para feminino ou 'M' para masculino.");
                }

            }
        }
    }
}
