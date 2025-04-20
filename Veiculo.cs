// Participantes: Igor Antônio Coral Rodrigues,Eduardo Henckemaier
// Lucas da Luz Vedana, Michel Furtado da Silva.
namespace RevendaAuto;

public abstract class Veiculo // Herança + Abstração
{
    // Encapsulamento
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public decimal Preco { get; set; }

    // Construtor
    public Veiculo(string marca, string modelo, int ano, decimal preco)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preco = preco;
    }

    // Método abstrato (Polimorfismo)
    public abstract string ExibirDetalhes();
}
