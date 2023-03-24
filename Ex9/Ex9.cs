namespace Ex9
//DUPLA: ENRICO E SAMIRA
{
    internal class Ex9
    {
        static void Main(string[] args)
        {
            double horas2, horas1, salario_1, salario_2;
            double minutos1, minutos2;


            Console.Write("Informe as horas de trabalho do Professor 1: ");
            horas1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe os minutos: ");
            minutos1 = Convert.ToSingle(Console.ReadLine());
            while (minutos1 > 59) //assegura que os minutos sejam escritos corretamente
            {
                Console.Write("Minutagem invalida, digite novamente: ");
                minutos1 = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Informe as horas de trabalho do Professor 2: ");
            horas2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe os minutos: ");
            minutos2 = Convert.ToSingle(Console.ReadLine());
            while (minutos2 > 59) //assegura que os minutos sejam escritos corretamente
            {
                Console.Write("Minutagem invalida, digite novamente: ");
                minutos2 = Convert.ToSingle(Console.ReadLine());
            }

            double minutos_decimal1 = (minutos1 / 100) * 0.60; //convertendo minutos para decimal
            double minutos_decimal2 = (minutos2 / 100) * 0.60; //convertendo minutos para decimal

            salario_1 = (horas1 + minutos_decimal1) * 80; //calculando salario1
            salario_2 = (horas2 + minutos_decimal2) * 75; //calculando salario2

            Console.WriteLine($"O Professor 1 trabalhou por {horas1}:{minutos1}H, e recebeu R${salario_1}."); //usei metodo de interpolaçao
            Console.WriteLine($"O Professor 2 trabalhou por {horas2}:{minutos2}H, e recebeu R${salario_2}."); //usei metodo de interpolação
            
            if (salario_1 == salario_2) 
            {
                Console.WriteLine("Os Professores receberam a mesma quantia (R$"+salario_1+").");
            }

            else if ( salario_1 > salario_2)
            {
                Console.WriteLine("O Professor 1 recebeu mais (R$" + salario_1 + ").");
            }

            else
            {
                Console.WriteLine("O Professor 2 recebeu mais (R$" + salario_2 + ").");
            }
        }
    }
}