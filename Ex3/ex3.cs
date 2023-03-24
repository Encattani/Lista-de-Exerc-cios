namespace Ex3 
 //DUPLA: ENRICO E SAMIRA
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            string nome, sexo;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine(); //recebe o nome do usuario

            Console.WriteLine("Informe seu sexo:");
            Console.Write("(F) ou (M): ");
            sexo = Convert.ToString(Console.ReadLine()).ToUpper(); //recebe a string 'f' ou 'm' e formata para 'F' ou 'M'
            

            if (sexo == "F") //valida se sexo = feminino
            {
                Console.WriteLine("Bem vinda Ilma. Sra. "+nome+".");
            }

            else if (sexo == "M")  // valida se sexo = masculino
            {
                Console.WriteLine("Bem vindo Ilmo. Sr. " + nome + ".");
            }

            else //caso o usuário não preencha o sexo com F ou M
            {
                Console.WriteLine("Bem vindo(a) Ilmo(a). Sr(a). " + nome + ".");
            }
        }
    }
}
