using sistema_bancario.Models;
using sistema_bancario.Models.sistema_bancario.Models;

Console.Write("Digite o nome do titular: ");
string titular = Console.ReadLine()!;

Console.Write("Digite o saldo inicial: ");
decimal saldo = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("\nEscolha o tipo de conta:");
Console.WriteLine("1 - Conta Corrente");
Console.WriteLine("2 - Conta Poupança");
Console.Write("Opção: ");

int tipo = int.Parse(Console.ReadLine()!);

Conta conta;

if (tipo == 1)
{
    conta = new ContaCorrente(titular, saldo);
}
else
{
    conta = new ContaPoupanca(titular, saldo);
}

int opcao;

do
{
    Console.WriteLine("\n========== MENU ==========");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Consultar saldo");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine()!);

    try
    {
        switch (opcao)
        {
            case 1:
                Console.Write("Digite o valor do depósito: ");
                decimal deposito = decimal.Parse(Console.ReadLine()!);

                conta.Depositar(deposito);
                Console.WriteLine("Depósito realizado com sucesso!");
                break;

            case 2:
                Console.Write("Digite o valor do saque: ");
                decimal saque = decimal.Parse(Console.ReadLine()!);

                conta.Sacar(saque);
                Console.WriteLine("Saque realizado com sucesso!");
                break;

            case 3:
                Console.WriteLine($"\nTitular: {conta.Titular}");
                Console.WriteLine($"Saldo atual: R$ {conta.Saldo:F2}");
                break;

            case 0:
                Console.WriteLine("Sistema encerrado.");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }

} while (opcao != 0);