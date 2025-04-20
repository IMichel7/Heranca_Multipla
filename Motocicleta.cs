// Participantes: Igor Antônio Coral Rodrigues,Eduardo Henckemaier
// Lucas da Luz Vedana, Michel Furtado da Silva.
namespace RevendaAuto;

public class Motocicleta : Veiculo
{
    public bool TemPartidaEletrica { get; set; }

    public Motocicleta(string marca, string modelo, int ano, decimal preco, bool temPartida)
        : base(marca, modelo, ano, preco)
    {
        TemPartidaEletrica = temPartida;
    }

    public override string ExibirDetalhes()
    {
        return $"[MOTO] {Marca} {Modelo}, Ano: {Ano}, Preço: {Preco:C}, Partida Elétrica: {(TemPartidaEletrica ? "Sim" : "Não")}";
    }
}
