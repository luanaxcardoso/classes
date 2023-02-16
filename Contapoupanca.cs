using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercioaula7
{
    public class Contapoupanca : ContaComum
    {
        public   void rendimento() { 

        }

        public override void abertura(double depositoInicial)
        {
            Saldo = depositoInicial;
        }
    }
}
