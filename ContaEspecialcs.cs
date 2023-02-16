using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercioaula7
{
    public class ContaEspecialcs : ContaComum
    {
        double limite;

        public double Limite {get; set;}

        public override void abertura(double depositoInicial) { 
            if ( depositoInicial > 1000) { Limite = 2000; }
            Saldo= depositoInicial;
        }

    }
}
