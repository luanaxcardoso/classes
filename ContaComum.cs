using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercioaula7
{
    public abstract class ContaComum
    {
        string numeroConta;
        double saldo;
        string titular;

        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public string Titular { get; set; }

        public abstract void abertura(double depositoInicial);
               
   
        public void deposito(double novoValor) {
            Saldo = novoValor + Saldo;
        }
        public void saque(double novoValor) {
            if (novoValor < Saldo) {
                Saldo = novoValor - Saldo;
            }
           

        }
        
    }
}
