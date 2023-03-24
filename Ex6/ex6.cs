namespace Ex6
//DUPLA: ENRICO E SAMIRA
{
    internal class ex6
    {
        static void Main(string[] args)
        {
            double preco_produto;
            int metodo_pagamento;

            Console.Write("Insira o valor do produto: ");
            preco_produto = Convert.ToDouble(Console.ReadLine());

            while (preco_produto <= 0 ) //condiçao que obriga o usuario a inserir um valor válido de preço
            {
                Console.Write("Valor inválido, insira novamente: ");
                preco_produto = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Escolha a forma de pagamento: ");
            Console.WriteLine("1 - À vista em dinheiro (10% de desconto)");
            Console.WriteLine("2 - À vista no cartão de crédito (15% de desconto)");
            Console.WriteLine("3 - Em duas vezes (sem desconto e sem juros");
            Console.WriteLine("4 - Em duas vezes (juros de 10%)");
            metodo_pagamento = Convert.ToInt32(Console.ReadLine());

            while (metodo_pagamento != 1 && metodo_pagamento != 2 && metodo_pagamento != 3 && metodo_pagamento != 4) ////condiçao que obriga o usuario a inserir uma opçao válida de metodo de pagamento
            {
                Console.WriteLine("Escolha uma opção válida: ");
                Console.WriteLine("1 - À vista em dinheiro (10% de desconto)");
                Console.WriteLine("2 - À vista no cartão de crédito (15% de desconto)");
                Console.WriteLine("3 - Em duas vezes (sem desconto e sem juros");
                Console.WriteLine("4 - Em duas vezes (juros de 10%)");
                metodo_pagamento = Convert.ToInt32(Console.ReadLine());
            }

            if (metodo_pagamento == 1) //condiçao para pagamento a vista com desconto de 10%
            {
                Console.WriteLine("O preço final é de R$" + preco_produto * 0.90 + ".");
            }

            else if (metodo_pagamento == 2) //condiçao para pagamento no credito com desconto de 15%
            {
                Console.WriteLine("O preço final é de R$" + preco_produto * 0, 85 + ".");
            }

            else if (metodo_pagamento == 3) //condiçao para 2 parcelas sem juros
            {
                Console.WriteLine("O preço final é de duas parcelas de R$"+preco_produto/2+".");
            }

            else if (metodo_pagamento == 4) //condiçao para 2 parcelas com juros de 10%
            {
                Console.WriteLine("O preço final é de duas parcelas de R$" + (preco_produto * 1.10) / 2+".");
            }
        }
    }
}