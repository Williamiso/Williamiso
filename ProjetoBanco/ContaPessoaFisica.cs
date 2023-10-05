using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ContaPessoaFisica : Conta
    {
        public ContaPessoaFisica()
        {
            this.Saldo = 0;
        }
        public override void depositar(double valor)
        {
            valor += Saldo;
        }
        public double exibeSaldo()
        {
            return Saldo;
        }

    }
}
