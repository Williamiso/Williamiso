using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulo2_ProjetoDoacao.Enum;

namespace Modulo2_ProjetoDoacao.Model
{
    internal class Roupa : Produto
    {
        public ECategoriaRoupa Categoria { get; set; }
        public ETamanho Tamanho { get; set; }
        public string Material { get; set; }
        public EComprimentoRoupa TipoComprimento { get; set; }
    }

    public void exibirRoupa()
    {
        
    }
}
