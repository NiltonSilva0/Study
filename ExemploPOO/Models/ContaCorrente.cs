using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo < valor) 
            {
                Console.WriteLine($"Você não possui saldo suficiente. Seu saldo é {Saldo}");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque realizado! Seu saldo agpra é {Saldo}");
            }
        }
        public void exibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {Saldo}");
        }
    }
}
