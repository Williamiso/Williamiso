using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividade
{
    public abstract class Conta
    {
        public double Saldo { get; set; }


        public abstract void Depositar(double valor);
        public abstract void Saque(double valor);

        public double exibirSaldo()
        {
            return Saldo;
        }
    }
}
