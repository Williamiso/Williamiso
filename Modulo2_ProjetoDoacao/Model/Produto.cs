using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2_ProjetoDoacao.Model
{
    internal class Produto
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public string genero { get; set; }
        public string foto { get; set; }

        public bool status;

        public string ExibirDados()
        {
            return "Nome: " + nome + "\nDescrição: " + descricao + "\nGênero: " + genero;
        }
    }
}
