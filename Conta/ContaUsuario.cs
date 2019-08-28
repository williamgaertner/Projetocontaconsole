using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conta
{
    class ContaUsuario
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaUsuario(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public ContaUsuario(int conta, string nome, double saldo) : this(conta, nome)
        {
            Saldo = saldo;
        }
    
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }
        public override string ToString()
        {
            return "Conta: " + Conta + ", Titular: " + Nome + ", Saldo: $ " + Saldo;
        }
    }
}
