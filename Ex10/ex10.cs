using System.Xml;

namespace Ex10
//DUPLA: ENRICO E SAMIRA
{
    internal class ex10
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.Write("Insira o codigo do produto: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            while (codigo == 7 || codigo <= 0 || codigo > 15 ) //assegura que o usuario insira um valor valido
            {
                Console.Write("Código inválido, insira o codigo novamente: ");
                codigo = Convert.ToInt32(Console.ReadLine());
            }

            if (codigo == 1) //condiçao para alimento nao perecivel
            {
                Console.WriteLine("Alimento não-perecível.");
            }

            else if (codigo >= 2 && codigo <= 4) //condiçao para alimento perecivel
            {
                Console.WriteLine("Alimento perecível.");
            }

            else if (codigo == 5 || codigo == 6) //condiçao para vestuario
            {
                Console.WriteLine("Vestuário.");
            }

            else if (codigo >= 8 && codigo <=15) //condiçao para higiene pessoal
            {
                Console.WriteLine("Higiene Pessoal");
            }

            else 

            {
                Console.WriteLine("Codigo inválido.");
            }
        }
    }
}