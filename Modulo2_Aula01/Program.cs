namespace Modulo2_Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um objeto do tipo Editora
            Editora edit = new Editora();

            edit.nome = "HarperCollins";
           


            //Instanciando um objeto do tipo Livro
           // Livro livro1 = new Livro();
           // livro1.nome = "As Crônicas de Nárnia - Coleção de Luxo";
           // livro1.valor = (-100);
           // livro1.resumo = ("Viagens ao fim do mundo, criaturas fantásticas e etc");
          //  livro1.paginas = (530);
            //livro1.autor = ("C. S. Lewis");

           // livro1.exibirDados();
           // edit.exibirDados();

            Livro livro = new Livro();
            livro.setNome("As Crônicas de Nárnia - Coleção de Luxo");
            Console.WriteLine
        }
    }
}