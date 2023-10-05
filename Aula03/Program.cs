namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, nota2, media, aulasdadas, aulasassistidas, frequencia;

           

            Console.WriteLine("Digite a nota 1");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número de aulas dadas");
            aulasdadas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de aulas assistidas");
            aulasassistidas = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            frequencia = (aulasassistidas / aulasdadas) * 100;

            if (media >= 7 && frequencia >= 75)
            {
                Console.WriteLine("Parabéns, foi aprovado!");
            }

            else
            {
                Console.WriteLine("Aluno reprovado!");
            }









            /*Console.WriteLine("Digite os 4 últimos números da sua placa: \n");
            int placa = Convert.ToInt32(Console.ReadLine());
            int finalplaca = placa % 10;
            switch (finalplaca)
            {

                case 1:
                case 2:
                    Console.WriteLine("\nRodízio na Segunda - Feira.");
                    break;

                case 3:
                case 4:
                    Console.WriteLine("\nRodízio na Terça - Feira.");
                    break;

                case 5:
                case 6:
                    Console.WriteLine("\nRodízio na Quarta - Feira.");
                    break;

                case 7:
                case 8:
                    Console.WriteLine("\nRodízio na Quinta - Feira.");
                    break;

                case 9:
                case 0:
                    Console.WriteLine("\nRodízio na Sexta - Feira.");
                    break;



                    
            }*/
        }
    }
}