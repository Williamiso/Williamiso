﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividade
{
    public class ContaPoupança : Conta
    {
        public override void Depositar(double valor)
        {
            base.Saldo += valor;
        }

        public override void Saque(double valor)
        {
            base.Saldo -= valor;
        }
    }
}
