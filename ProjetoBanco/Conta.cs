using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal abstract class Conta
    {
        public int Numero { get; set; }

        public Double Saldo { get; set; }

        public Agencia Agencia { get; set; }

        public ESituacao Situacao { get; set; }

        //Métodos

        public abstract void depositar(double valor);

        public double exibeSaldo()
        {
            return 1000000.00;
        }
    }
}
