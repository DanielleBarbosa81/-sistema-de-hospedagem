namespace SistemaHospedagem.Models;

public class Pessoa
{
    public required  string Nome { get; set; }
    public required  string Sobrenome { get; set; }

    public string NomeCompleto => $"{Nome} {Sobrenome}";
}
