using BancoAtividadeInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividadeInterface.Models
{
    public class ContaPoupança : IConta
    {

        public double Saldo { get; set; }
        private const double taxa = 0.30;

        public void depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void sacar(double valor)
        {
            this.Saldo -= valor + taxa;
        }

        public double exibirSaldo()
        {
            return this.Saldo;
        }
    }
}
