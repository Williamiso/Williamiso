namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;

           

            
           Console.WriteLine("Coloque a nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque a nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque a nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = ((nota1 + nota2 + nota3) / 3);

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            
            }
        }
    }
}