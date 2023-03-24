namespace Ex5
//DUPLA: ENRICO E SAMIRA
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c)  //condição para validar se a soma de A e B é maior que C.
            {
                Console.WriteLine("A soma do primeiro e do segundo valor é maior que o terceiro valor.");
            }

            else  //qualquer condição que A + B < C
            {
                Console.WriteLine("A soma do primeiro e do segundo valor não é maior que o terceiro valor.");
            }
        }
    }
}