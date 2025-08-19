namespace SistemaHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new();
    public required  Suite Suite { get; set; }
    public required int DiasReservados { get; set; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count <= Suite.Capacidade)
            Hospedes = hospedes;
        else
            throw new Exception("Capacidade da suíte excedida.");
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes() => Hospedes.Count;

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;
        if (DiasReservados > 10)
            valor *= 0.9m; // 10% de desconto
        return valor;
    }
}
