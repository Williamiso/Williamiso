using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2_ProjetoDoacao.Model
{
    internal class Usuario
    {
        public string nome;
        public string telefone;
        public string email;
        public string senha;
        public string apelido;

        public string ExibirDados()
        {
            return "Nome: " + nome + "\nTelefone: " + telefone + "\nEmail: " + email;
        }


    }
}
