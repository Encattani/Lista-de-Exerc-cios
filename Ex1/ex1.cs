namespace Ex1
//DUPLA: ENRICO E SAMIRA
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um numero entre 1 e 9: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 1 && numero <= 9) //checa se está dentro dos limites estabelecidos
            {
                Console.WriteLine("O valor está na faixa permitida");
            }
            else 
            {
                Console.WriteLine("O valor está fora da faixa permitida");
            }
        }
    }
}

