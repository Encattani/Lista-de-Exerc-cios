namespace Ex4
//DUPLA: ENRICO E SAMIRA
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            double altura;
            string sexo;

            Console.Write("Informe sua altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine()); //recebe o valor da altura do usuario

            Console.WriteLine("Informe seu sexo:");
            Console.Write("(F) ou (M): ");
            sexo = Convert.ToString(Console.ReadLine()).ToUpper(); //recebe a string 'f' ou 'm' e formata para 'F' ou 'M'

            while (sexo != "F" && sexo != "M") //condição para caso o usuario digitar errado o sexo
            {
                Console.WriteLine("Erro salvar o sexo, por favor, digite novamente");
                Console.Write("(F) ou (M): ");
                sexo = Convert.ToString(Console.ReadLine()).ToUpper();
            }

            if (sexo == "M") //condição para calcular o peso do sexo masculino
            {
                Console.WriteLine("O seu peso ideal é: " + ((72.7 * altura) - 58));
            }

            else if (sexo == "F") //condição para calcular o peso do sexo feminino
            {
                Console.WriteLine("O seu peso ideal é: " + ((62.1 * altura) - 44.7));
            }


        }
    }
}