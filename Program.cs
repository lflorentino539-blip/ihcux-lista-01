// See https://aka.ms/new-console-template for more information
//Heurísticas de Nielsen aplicadas:

//#1 - Visibilidade do Status do Sistema:
//O sistema informa em qual etapa o usuário está através das mensagens
//[Passo 1], [Passo 2] e [Passo 3].

//#3 - Controle e Liberdade do Usuário:
//O usuário pode digitar "cancelar" para encerrar o pedido a qualquer momento
//ou "voltar" para retornar ao início e corrigir informações.

//#9 - Ajuda os Usuários a Reconhecer, Diagnosticar e Corrigir Erros:
//O sistema apresenta mensagens claras quando ocorre erro, como entrada inválida
//ou código fora do intervalo, orientando o usuário sobre como corrigir.

using System;

class Program
{
    static void Main()
    {
        int codigo = 0;
        int quantidade = 0;

        // PASSO 1
        while (true)
        {
            Console.WriteLine("\n[Passo 1] Código do produto (1 a 10)");
            string entrada = Console.ReadLine().ToLower();

            if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (!int.TryParse(entrada, out codigo))
            {
                Console.WriteLine("Digite um número válido.");
                continue;
            }

            if (codigo < 1 || codigo > 10)
            {
                Console.WriteLine($"Código {codigo} não existe. Use de 1 a 10.");
                continue;
            }

            break;
        }

        // PASSO 2
        while (true)
        {
            Console.WriteLine("\n[Passo 2] Quantidade:");
            string entrada = Console.ReadLine().ToLower();

            if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (entrada == "voltar")
            {
                Main(); // volta pro início (simples)
                return;
            }

            if (!int.TryParse(entrada, out quantidade) || quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida.");
                continue;
            }

            break;
        }

        // PASSO 3
        Console.WriteLine("\n[Passo 3] Confirmação");
        Console.WriteLine($"Produto: {codigo}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine("Digite 'sim' para confirmar ou 'cancelar'");

        string confirmacao = Console.ReadLine().ToLower();

        if (confirmacao == "sim")
        {
            Console.WriteLine("Pedido feito com sucesso!");
        }
        else
        {
            Console.WriteLine("Pedido cancelado.");
        }
    }
}
