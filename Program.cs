// Participantes: Igor Antônio Coral Rodrigues,Eduardo Henckemaier
// Lucas da Luz Vedana, Michel Furtado da Silva.
using System;
using RevendaAuto;

internal class Program
{
    private static void Main(string[] args)
    {
        Revenda minhaRevenda = CriarRevenda();
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\n======= MENU =======");
            Console.WriteLine("1 - Adicionar Veículo");
            Console.WriteLine("2 - Listar todos os veículos");
            Console.WriteLine("3 - Listar somente carros");
            Console.WriteLine("4 - Listar somente motocicletas");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarVeiculo(minhaRevenda);
                    break;
                case "2":
                    minhaRevenda.ListarVeiculos();
                    break;
                case "3":
                    minhaRevenda.ListarPorTipo(typeof(Carro));
                    break;
                case "4":
                    minhaRevenda.ListarPorTipo(typeof(Motocicleta));
                    break;
                case "0":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    private static Revenda CriarRevenda()
    {
        Console.WriteLine("== Cadastro da Revenda ==");
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Endereço: ");
        string endereco = Console.ReadLine()!;
        return new Revenda(nome, endereco);
    }

    private static void AdicionarVeiculo(Revenda revenda)
    {
        Console.WriteLine("\n== Cadastro de Veículo ==");
        Console.WriteLine("1 - Carro");
        Console.WriteLine("2 - Motocicleta");
        Console.Write("Escolha o tipo: ");
        string? tipo = Console.ReadLine();

        Console.Write("Marca: ");
        string marca = Console.ReadLine()!;
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine()!;
        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine()!);
        Console.Write("Preço: ");
        decimal preco = decimal.Parse(Console.ReadLine()!);

        if (tipo == "1")
        {
            Console.Write("Número de portas: ");
            int portas = int.Parse(Console.ReadLine()!);
            Carro carro = new Carro(marca, modelo, ano, preco, portas);
            revenda.AdicionarVeiculo(carro);
        }
        else if (tipo == "2")
        {
            Console.Write("Possui partida elétrica? (s/n): ");
            bool partida = Console.ReadLine()!.ToLower() == "s";
            Motocicleta moto = new Motocicleta(marca, modelo, ano, preco, partida);
            revenda.AdicionarVeiculo(moto);
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
        }
    }
}
