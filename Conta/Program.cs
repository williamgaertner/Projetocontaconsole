using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaUsuario Contas;

            Console.Write("Entre o numero da conta: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Entre nome usuario: ");
            string Nome = Console.ReadLine();
            Console.Write("Havera deposito (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Qual o valor para deposito: ");
                double DepInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Contas = new ContaUsuario(Numero, Nome, DepInicial);
            }
            else
            {
                Contas = new ContaUsuario(Numero, Nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados usuario");
            Console.WriteLine(Contas);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double DepositoIncremento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contas.Deposito(DepositoIncremento);
            Console.WriteLine("dados atualizados");
            Console.WriteLine(Contas);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double SaqueIncremento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contas.Saque(SaqueIncremento);
            Console.WriteLine("dados atualizados");
            Console.WriteLine(Contas);
            Console.ReadLine();
        }
    }
}
