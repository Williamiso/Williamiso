using BancoAtividadeInterface.Models;

namespace BancoAtividadeImplementação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.depositar(1000);
            cc.sacar(500);
            //Console.WriteLine("Saldo: " + cc.exibirSaldo());

            ContaPoupança cp = new ContaPoupança();
            cp.depositar(1000);
            cp.sacar(500);

            ControladorExtrato ce = new ControladorExtrato();
            ce.geradorExtrato(cc);
            ce.geradorExtrato(cp);
        }
    }
}