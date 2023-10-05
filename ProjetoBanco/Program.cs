namespace ProjetoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPessoaFisica contaF = new ContaPessoaFisica();
            contaF.Numero = 121212;
            contaF.Situacao = ESituacao.Aberta;
            contaF.Saldo = 500;
            Console.WriteLine("Saldo: " + contaF.exibeSaldo());
                      

           
        }
    }
}