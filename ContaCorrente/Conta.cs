using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Conta
    {
        private string Numero;
        private string Nome;
        internal float Saldo;


        public void CriacaoDeConta()
        {
            Console.WriteLine("ABERTURA DE NOVA CONTA");

            Console.WriteLine("Qual o nome do cliente?");
            Nome = Console.ReadLine();

            Console.WriteLine("Qual o saldo inicial da conta?");
            Saldo = float.Parse(Console.ReadLine());
        }

        public Conta()
        {
        }

        public string ExibeInfo()
        {
            return "--Conta corrente nº " + Numero + "\n--Cliente " + Nome;
        }

        public void Deposito(float valor)
        {
            Saldo += valor;
        }

        public void Saque(float valor)
        {
            Saldo -= valor;
        }

        public string ConsultaSaldo()
        {
            return "Saldo R$ " + Saldo.ToString("F2");
        }

    }
}
