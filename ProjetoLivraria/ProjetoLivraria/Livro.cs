using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria
{
    public class Livro
    {
        //Definir atributos
       
        public string Nome { get; set; }
        public string Resumo { get; set; }
        public double Valor { get; set; }
        public int Paginas { get; set; }
        public string Autor { get; set; }

        public Editora Editora { get; set; }

        //construtor

        public Livro()
        {

        }

        public Livro (string nome)
        {
            this.Nome = nome;
        }

        public Livro(string nome, string resumo, string autor, double valor, int paginas )
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Valor = valor;
            this.Resumo = resumo;
            this.Paginas = paginas;
        }


        //Definir métodos

        public void exibirDados()
        {
            //definição de váriavel
            String titulo = "DETALHES DO LIVRO";
            Console.WriteLine(titulo);

            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Resumo: " + Resumo);
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine("Paginas: " + Paginas);
        }
    }
}
