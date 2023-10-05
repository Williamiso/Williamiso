namespace BancoAtividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCC = new ContaCorrente();
            contaCC.Depositar(100);
            contaCC.Saque(50);
            contaCC.Depositar(1000);
            Console.WriteLine("Saldo Conta Corrente: " + contaCC.exibirSaldo());
        }
    }
}