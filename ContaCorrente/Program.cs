using System;
using System.Collections.Generic;

namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Conta> contas = new List<Conta>();
            contas.Add(new Conta());
            contas[0].CriacaoDeConta();
            Console.WriteLine("\n" + contas[0].ExibeInfo());   

            Console.WriteLine("\nSelecione qual operacao deseja realizar:" +
                "\n1- Consultar saldo" +
                "\n2- Depositar valor" +
                "\n3- Sacar valor" +
                "\n4- Criar nova conta");
            char operador = char.Parse(Console.ReadLine());
            float valor;
            char repetirPrograma = 'S';

            while (repetirPrograma == 'S' || repetirPrograma == 's')
            {
                if (operador == '1')
                {
                    Console.WriteLine("\n" + contas[0].ConsultaSaldo());
                    Console.ReadLine();
                }

                else if (operador == '2')
                {
                    Console.WriteLine("\nQual valor deseja depositar?");
                    valor = float.Parse(Console.ReadLine());

                    contas[0].Deposito(valor);
                }

                else if (operador == '3')
                {
                    Console.WriteLine("\nQual valor deseja sacar?");
                    valor = float.Parse(Console.ReadLine());

                    contas[0].Saque(valor);
                }

                /*else if (operador == 4)
                {
                    contas
                }*/

                else
                {
                    Console.WriteLine("\nOperação inválida!");
                }

                Console.WriteLine("Deseja realizar outra operação?\nSe sim, digite 'S' ou 's'.");
                repetirPrograma = char.Parse(Console.ReadLine());

                if (repetirPrograma == 'S' || repetirPrograma == 's')
                {
                    Console.WriteLine("\nSelecione qual operacao deseja realizar: \n1- Consultar saldo\n2- Depositar valor\n3- Sacar valor");
                    operador = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Programa finalizado.");
            Console.ReadLine();            
        }
    }
}
