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

        public Conta(string numero, string nome, float saldo)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Saldo = saldo;
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
