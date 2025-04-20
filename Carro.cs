// Participantes: Igor Antônio Coral Rodrigues,Eduardo Henckemaier
// Lucas da Luz Vedana, Michel Furtado da Silva.
namespace RevendaAuto;

public class Carro : Veiculo
{
    public int Portas { get; set; }

    public Carro(string marca, string modelo, int ano, decimal preco, int portas)
        : base(marca, modelo, ano, preco)
    {
        Portas = portas;
    }

    public override string ExibirDetalhes() // Polimorfismo
    {
        return $"[CARRO] {Marca} {Modelo}, Ano: {Ano}, Preço: {Preco:C}, Portas: {Portas}";
    }
}
