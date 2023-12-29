using System;
using System.Collections.Generic;

namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABERTURA DE NOVA CONTA");

            Console.WriteLine("Qual o nome do cliente?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o saldo inicial da conta?");
            float saldoInicial = float.Parse(Console.ReadLine());



            List<Conta> contas = new List<Conta>();
            contas.Add(new Conta("0001", nome, saldoInicial));
            Console.WriteLine(contas[0].ExibeInfo());   

            Console.WriteLine("\nSelecione qual operacao deseja realizar: \n1- Consultar saldo\n2- Depositar valor\n3- Sacar valor");
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
