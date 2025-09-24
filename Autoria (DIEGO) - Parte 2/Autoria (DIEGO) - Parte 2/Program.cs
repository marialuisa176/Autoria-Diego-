// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class CantinaEscolar
{
    //Informa os preços dos itens da cantina
    static Dictionary<string, double> precosCantina = new Dictionary<string, double>()
    {
        { "Refrigerante", 4.00 },
        { "Água", 2.50 },
        { "Salgado", 3.00 },
        { "Biscoito", 1.50 },
        { "Suco", 3.50 },
        { "Pipoca", 2.00 }
    };

    // Variável para armazenar o total da compra
    static double totalCompra = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            // Exibe o menu de itens da cantina
            Console.Clear();
            Console.WriteLine("==== Menu Cantina Escolar ====");
            Console.WriteLine("1. Adicionar item ao carrinho");
            Console.WriteLine("2. Finalizar compra");
            Console.WriteLine("3. Sair");
            Console.WriteLine("==============================");
            Console.Write("Escolha uma opção (1, 2 ou 3): ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                // Adicionar item ao carrinho
                Console.WriteLine("Itens disponíveis:");
                foreach (var item in precosCantina)
                {
                    Console.WriteLine($"{item.Key}: R$ {item.Value:F2}");
                }

                Console.Write("Digite o nome do item que deseja adicionar ao carrinho: ");
                string itemEscolhido = Console.ReadLine();

                // Verifica se o item existe na cantina
                if (precosCantina.ContainsKey(itemEscolhido))
                {
                    Console.Write($"Quantos {itemEscolhido}s você deseja? ");
                    int quantidade = int.Parse(Console.ReadLine());
                    totalCompra += precosCantina[itemEscolhido] * quantidade; // Acumula o total na variável global
                    Console.WriteLine($"Você adicionou {quantidade} {itemEscolhido}(s) ao carrinho.");
                }
                else
                {
                    Console.WriteLine("Item não encontrado na cantina.");
                }
            }
            else if (opcao == "2")
            {
                // Finalizar compra
                Console.WriteLine($"Total da compra: R$ {totalCompra} - Pedido separado! Dirija-se a cantina para realizar o pagamento");
            }
            else (opcao == "3")
            {
                // Sair do sistema de pedidos
                Console.WriteLine("Obrigado por usar o sistema da cantina!");
            }
        }
    }
}
