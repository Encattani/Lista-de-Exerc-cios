namespace Ex2
//DUPLA: ENRICO E SAMIRA
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            int l1, l2, l3; //lados do triangulo

            Console.Write("Insira o valor do lado 1: ");
            l1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o valor do lado 2: ");
            l2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o valor do lado 3: ");
            l3 = Convert.ToInt32(Console.ReadLine());


            if (l1 + l2 < l3 || l2 + l3 < l1 || l1 + l3 < l2 || l1 == 0 || l2 == 0 || l3 == 0) //condição para o triangulo não existir
            {
                Console.WriteLine("O triangulo não existe");
            }

            else if (l1 == l2 && l1 == l3) //checando se é triangulo equilatero
            {
                Console.WriteLine("O triangulo é equilátero.");
            }

            else if (l1 == l2 || l1 == l3 || l2 == l3) //checando se é isosceles
            {
                Console.WriteLine("O triangulo é isósceles");
            }

            else
            {
                Console.WriteLine("O triangulo é escaleno."); //se não validar ate aqui, é escaleno
            }

        }
    }
}