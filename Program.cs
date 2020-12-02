using System;

namespace CalculadoraFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {

            Console.WriteLine("#################################");
            Console.WriteLine("##       CALCULADORA C#        ##");
            Console.WriteLine("#################################");
            Console.WriteLine("##       Escolha uma opção     ##");
            Console.WriteLine("#################################");
            
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");

            string tmp;

            Console.WriteLine("Digite um número referente a opção desejada");
            tmp = Console.ReadLine();
            int option = int.Parse(tmp);

            switch (option)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }

        }   

        static void Soma() {

            double n1, n2;
            string tmp; 

            Console.WriteLine("Digite o primeiro número:");
            tmp = Console.ReadLine();
            n1 = int.Parse(tmp);
            Console.WriteLine("Digite o segundo número:");
            tmp = Console.ReadLine();
            n2 = int.Parse(tmp);      
            double soma = n1 + n2; 
            Console.WriteLine("O resultado é:" + ' ' + soma);
                
        }

        static void Subtracao() {

            double n1, n2;
            string tmp; 

            Console.WriteLine("Digite o primeiro número:");
            tmp = Console.ReadLine();
            n1 = int.Parse(tmp);
            Console.WriteLine("Digite o segundo número:");
            tmp = Console.ReadLine();
            n2 = int.Parse(tmp);
            double subtracao = n1 - n2; 
            Console.WriteLine("O resultado é:" + ' ' + subtracao);

        }

        static void Multiplicacao() {

            double n1, n2;
            string tmp; 

            Console.WriteLine("Digite o primeiro número:");
            tmp = Console.ReadLine();
            n1 = int.Parse(tmp);
            Console.WriteLine("Digite o segundo número:");
            tmp = Console.ReadLine();
            n2 = int.Parse(tmp);
            double multiplicacao = n1 * n2; 
            Console.WriteLine("O resultado é:" + ' ' + multiplicacao);

        }

        static void Divisao() {

            double n1, n2;
            string tmp; 

            Console.WriteLine("Digite o primeiro número:");
            tmp = Console.ReadLine();
            n1 = int.Parse(tmp);
            Console.WriteLine("Digite o segundo número:");
            tmp = Console.ReadLine();
            n2 = int.Parse(tmp);
            double divisao = n1 / n2; 
            Console.WriteLine("O resultado é:" + ' ' + divisao );

        }

        static void Sair() {

            System.Environment.Exit(1);

        }
    }
}
