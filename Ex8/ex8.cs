namespace Ex8
//DUPLA: ENRICO E SAMIRA
{
    internal class ex8
    {
        static void Main(string[] args)
        {
            double n1, n2; //variaveis numero1 e numero2
            string escolha;


            Console.Write("Digite o valor do numero 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());           

            Console.Write("Digite o valor do numero 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha o resultado que deseja ver: ");
            Console.WriteLine("(A) - Resultado da soma.");
            Console.WriteLine("(S) - Resultado da subtração.");
            Console.WriteLine("(M) - Resultado da multiplicação. ");
            Console.WriteLine("(Q) - O quociente inteiro a divisão.");
            escolha = Console.ReadLine().ToUpper();
            
            if (escolha == "A") //condiçao para soma dos valores
            {
                Console.WriteLine("O resultado é: "+(n1 + n2));
            }

            else if (escolha == "S") //condiçao para subtração dos valores
            {
                Console.WriteLine("O resultado é: "+(n1 - n2));
            }

            else if (escolha == "M") //condiçao para multiplicaçao dos valores
            {
                Console.WriteLine("O resultado é: "+(n1 * n2));
            }

            else if (escolha == "Q") //condiçao para divisao dos valores
            {
                   Console.WriteLine("O resultado da divisão é: "+ (n1/n2));
            }
            
            else //condiçao de erro 
            {
                Console.WriteLine("Escolha inválida, fechando o programa.");
            }
        }
    }
}