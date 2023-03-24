namespace Ex7
//DUPLA: ENRICO E SAMIRA
{
    internal class ex7
    {
        static void Main(string[] args)
        {
            int ano_atual, ano_nascimento;

            Console.Write("Insira o ano atual: ");
            ano_atual = Convert.ToInt32(Console.ReadLine());

            while (ano_atual < 1900) //condição para o usuário inserir um ano valido
            {
                Console.Write("Ano invalido, digite novamente: ");
                ano_atual = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Insira seu ano de nascimento: ");
            ano_nascimento = Convert.ToInt32(Console.ReadLine());

            while (ano_nascimento > ano_atual) //condição para o usuário inserir um ano valido
            {
                Console.Write("Ano invalido, digite novamente: ");
                ano_nascimento = Convert.ToInt32(Console.ReadLine());
            }

            if (ano_atual - ano_nascimento >= 18) //condiçao para checar se a pessoa ja pode votar e dirigir
            {
                Console.Write("Você ja pode tirar titulo de eleitor e a carteira de motorista!");
            }

            if (ano_atual - ano_nascimento >= 16 && ano_atual - ano_nascimento < 18) //condiçao para checar se a pessoa pode votar apenas
            {
                Console.Write("Você ja pode tirar titulo de eleitor!");

            }

            else
            {
                Console.WriteLine("Você ainda não pode votar, nem tirar CNH.");
            }
        }
    }
}