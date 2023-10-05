using Modulo2_ProjetoDoacao.Enum_Calçado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2_ProjetoDoacao.Model
{
    internal class Calçado : Produto
    {
        public ECategoriaCalcado Categoria { get; set; }
        public ETamanhoCalcado Tamanho { get; set; }
        public string Material { get; set; }
        public ETipoAjuste TipoAjuste { get; set; }

    }

    public void ExibirCalçado()
    {
        Console.WriteLine();
    }
}
