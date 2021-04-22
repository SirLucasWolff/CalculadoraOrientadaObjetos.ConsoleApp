using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaObjetos.ConsoleApp
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int numero1, numero2, resultado = 0;

            string operacao;

            Console.WriteLine("Digite o primeiro número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação:");
            operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo número:");
            numero2 = int.Parse(Console.ReadLine());

            switch(operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;

            }


            Console.ReadKey(true);
        }
    }
}
