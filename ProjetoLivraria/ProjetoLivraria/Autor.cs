using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria
{
    public class Autor
    {
        
        public string Id { get; set; }
        public string Nome { get; set; }
        
        public Autor()
        {

        }

        public Autor(string Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
        
    }
}
