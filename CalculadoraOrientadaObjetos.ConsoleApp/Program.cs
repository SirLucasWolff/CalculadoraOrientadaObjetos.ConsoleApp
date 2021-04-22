using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientadaObjetos.ConsoleApp
{
    class Program
    {
        static string[] operacoesRealizadas = new string[100];
        private static string simboloOperacao;
        private static int primeiroNumero;
        private static int segundoNumero;
        private static int contadorOperacoesRealizadas;
        private static string operacaoRealizada;

        //Orientada a objetos

        public double som(double num1, double num2)
        {
            return num1 + num2;
        }

        public double sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public double div(double num1, double num2)
        {
            return num1 / num2;
        }

        public double mult(double num1, double num2)
        {
            return num1 * num2;
        }

        public static bool Main(string[] args)
        {
            int resultado = 0;

            string opcao;

            //Menu Interativo

            Console.WriteLine("Digite 1 para somar;");

            Console.WriteLine("Digite 2 para subtrair:");

            Console.WriteLine("Digite 3 para multiplicar:");

            Console.WriteLine("Digite 4 para dividir:");

            Console.WriteLine("Digite 5 para vizualizar os cálculos:");

            Console.WriteLine("Digite s para sair:");

            opcao = Console.ReadLine();

            return opcao != "1" && opcao != "2" && opcao != "3"
                                && opcao != "4" && opcao != "5"
                                && opcao != "s";

            //Opções do menu

            if (opcao == "1")
            {
                Console.WriteLine("Digite o primeiro número:");
                primeiroNumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                segundoNumero = int.Parse(Console.ReadLine());

                Console.WriteLine(resultado);
            }

            if (opcao == "2")
            {
                Console.WriteLine("Digite o segundo número:");
                primeiroNumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                segundoNumero = int.Parse(Console.ReadLine());

                Console.WriteLine(resultado);
            }

            if (opcao == "3")
            {
                Console.WriteLine("Digite o segundo número:");
                primeiroNumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                segundoNumero = int.Parse(Console.ReadLine());

                Console.WriteLine(resultado);
            }

            if (opcao == "4")
            {
                Console.WriteLine("Digite o segundo número:");
                primeiroNumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                segundoNumero = int.Parse(Console.ReadLine());

                Console.WriteLine(resultado);
            }

            if (opcao == "5")
            {
                for (int i = 0; i < operacoesRealizadas.Length; i++)
                {
                    if (operacoesRealizadas[i] != null)
                        Console.WriteLine(operacoesRealizadas[i]);
                }
            }

            //Armazenamento de dados

            switch (opcao)
            {
                case "1": simboloOperacao = "+"; break;

                case "2": simboloOperacao = "+"; break;

                case "3": simboloOperacao = "+"; break;

                case "4": simboloOperacao = "+"; break;

                default:
                    break;
            }

            switch (opcao)
            {
                case "1": resultado = primeiroNumero + segundoNumero; break;

                case "2": resultado = primeiroNumero - segundoNumero; break;

                case "3": resultado = primeiroNumero * segundoNumero; break;

                case "4": resultado = primeiroNumero / segundoNumero; break;

                default:
                    break;
            }

            
        }
    }
}



        

