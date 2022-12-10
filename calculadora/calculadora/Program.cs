using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem-Vindo(a) a calculadora do Luiz");
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão  \n");

            Console.ReadLine();

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
            }

        }

        public static int Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }

    }

}
