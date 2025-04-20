// Participantes: Michel Silva, [outros nomes aqui]
namespace RevendaAuto;

public class Revenda
{
    public string Nome { get; set; }
    public string Endereco { get; set; }

    // Lista contendo todos os veículos cadastrados (Encapsulamento)
    public List<Veiculo> Veiculos { get; set; }

    // Construtor
    public Revenda(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
        Veiculos = new List<Veiculo>();
    }

    // Método para adicionar um veículo na revenda
    public void AdicionarVeiculo(Veiculo v)
    {
        Veiculos.Add(v);
        Console.WriteLine("Veículo adicionado com sucesso!");
    }

    // Lista todos os veículos cadastrados
    public void ListarVeiculos()
    {
        Console.WriteLine($"\nRevenda: {Nome} - {Endereco}");
        Console.WriteLine("== Veículos no pátio ==");
        if (Veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo cadastrado.");
            return;
        }

        foreach (var v in Veiculos)
        {
            Console.WriteLine(v.ExibirDetalhes()); // Polimorfismo
        }
    }

    // Lista apenas veículos de um tipo específico (ex: Carro, Motocicleta)
    public void ListarPorTipo(Type tipo)
    {
        Console.WriteLine($"\n== Veículos do tipo {tipo.Name} ==");
        var encontrados = Veiculos.Where(v => v.GetType() == tipo).ToList();

        if (encontrados.Count == 0)
        {
            Console.WriteLine("Nenhum veículo encontrado desse tipo.");
            return;
        }

        foreach (var v in encontrados)
        {
            Console.WriteLine(v.ExibirDetalhes());
        }
    }
}
