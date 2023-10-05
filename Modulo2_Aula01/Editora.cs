using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2_Aula01
{
    internal class Editora
    {
        public string nome;
        public string site;
        public string telefone;

        public void exibirDados()
        {
            String titulo = "EDITORA";
            Console.WriteLine(titulo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Site: " + site);
            Console.WriteLine("Telefone: " + telefone);
        }
    }
}
