using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2_Aula01
{
    internal class Livro
    {
        //Definir os atributos
        public string nome;
        public string resumo;
        public double valor;
        public int paginas;
        public string autor;

        public void exibirDados()
        {
            String titulo = "DETALHES DO LIVRO";
            Console.WriteLine(titulo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Resumo: " + resumo);
            Console.WriteLine("Valor: " + valor);
            Console.WriteLine("Páginas: " + paginas);

        }
        //construtor

        public Livro()
        {

        }

        public Livro (string nome)
        {
            this.Nome = nome;
        }

        public Livro(string nome, string resumo, string autor, double valor, int paginas)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Valor = valor;
            this.Resumo = resumo;
            this.Paginas = paginas;
        }


        //Definir os métodos
    }
}
