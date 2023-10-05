using BancoAtividadeInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividadeInterface.Models
{
    internal class ControladorExtrato
    {
        public void geradorExtrato(IConta conta)
        {
            Console.WriteLine(conta.exibirSaldo());
        }
    }
}
