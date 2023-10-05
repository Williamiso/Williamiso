using System.Collections;

namespace ProjetoLivraria
{
    public class Program
    {

        public static void ExibeLista(ArrayList array)

        {
            foreach(string i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n---------------------------\n");
        }

        public static void ExibeListaTiposDiferentes(ArrayList array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\n---------------------------\n");
        }


        static void Main(string[] args)
        {

            ArrayList teste = new ArrayList();
            teste.Add("Ana");
            teste.Add("Eliane");
            teste.Add("Maria");
            teste.Add("Elaine");
            ExibeLista(teste);

            ArrayList teste1 = new ArrayList();
            teste1.Add("Ana");
            teste1.Add("Eliane");
            teste1.Add("Maria");
            teste1.Add("Elaine");
            ExibeListaTiposDiferentes(teste1);

            List<Editora> lista = new List<Editora>();


            lista.Add(new Editora("Editora A", "site da Editora A", "telefone Editora A"));

            Editora editora = new Editora();
            editora.Nome = "Editora B";
            editora.Site = "Site da Editora B";
            editora.Telefone = "Telefone Editora B";
            lista.Add(editora);

            Editora editora1 = new Editora("Editora C", "site da Editora C", "telefone Editora C");
            lista.Add(editora1);

            lista.Remove(editora1);

            Console.WriteLine(lista.Where(x=>x.Nome.Equals("Editora A")).First().Nome);
            Console.WriteLine(lista.Where(x=>x.Site.Equals("Site da Editora B")).First().Site);

            List<Autor> list = new List<Autor>();
            list.Add(new Autor("ID do Autor A", "Nome do Autor A"));

            ////Instanciando um objeto do tipo Livro utilizando o contrutor sem parâmetros, cria os objetos em memória com valores default
            //Console.WriteLine("Livro com construtor sem parâmetros: ");
            //Livro livro1 = new Livro();
            //livro1.Nome = ("As Crônicas de Nárnia - Coleção de Luxo");
            //livro1.Valor = (100);
            //livro1.Resumo = ("Viagen ao fim do mundo, criaturas fantásticas e " +
            //    "batalhas épicas entre o bem e o mal -" +
            //    "o que mais um leitor poderia querer de um livro?");
            //livro1.Paginas = (752);
            //livro1.Autor = ("C. S. Lewis");

            ////Instanciando um objeto do tipo Editora
            //Editora editora = new Editora();
            //editora.Nome = "xxxxx";
            //editora.Telefone = "19 88888-88888";

            //Editora editora1= new Editora();
            //editora1.Nome = "HarperrCollins";
            //editora1.Telefone = "19 88888-88888";
            //livro1.Editora = editora1;
            //livro1.exibirDados();

            //Console.WriteLine("---------------------------------------------------------");


            //Livro livro2 = new Livro("As Crônicas de Nárnia - Coleção de Luxo");
            //Console.Write("Livro com construtor de 1 parâmetro: \n");
            //livro2.exibirDados();
            //Console.WriteLine("---------------------------------------------------------");

            //Livro livro3 = new Livro("As Crônicas de Nárnia - Coleção de Luxo" ,
            //    "Viagen ao fim do mundo, criaturas fantásticas e " +
            //   "batalhas épicas entre o bem e o mal -" +
            //  "o que mais um leitor poderia querer de um livro?" , "C.S.Lewis", 100, 752);
            //Console.Write("\nLivro com construtor com todos parâmetros: \n");
            //livro3.exibirDados();
            //Console.WriteLine("---------------------------------------------------------");
        }
    }
}