using Modulo2_ProjetoDoacao.Enum;
using Modulo2_ProjetoDoacao.Enum_Calçado;
using Modulo2_ProjetoDoacao.Model;

namespace Modulo2_ProjetoDoacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Roupa roupa = new Roupa();
            roupa.Categoria = ECategoriaRoupa.Camisetas;
            roupa.Tamanho = ETamanho._4;
            roupa.TipoComprimento = EComprimentoRoupa.Mini;

            Calçado calçado = new Calçado();
            calçado.Categoria = ECategoriaCalcado.Tênis;
            calçado.Tamanho = ETamanhoCalcado._30;
            calçado.TipoAjuste = ETipoAjuste.Cadarço;


            Usuario user = new Usuario();
            Console.WriteLine("Digite o usuário: ");
            user.nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            user.telefone = Console.ReadLine();
            Console.WriteLine("Digite o e-mail: ");
            user.email = Console.ReadLine();
            Console.WriteLine(user.ExibirDados());



        }
    }
}