using SistemaHospedagem.Models;

Console.WriteLine("Bem-vindo ao sistema de hospedagem!");
Console.WriteLine("Vamos realizar uma reserva.");

Console.WriteLine("Informe o tipo da suíte (Simples, Luxo, Presidencial):");
string tipoSuite = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Informe a capacidade da suíte:");
int capacidade = int.Parse(Console.ReadLine() ?? "1");
Console.WriteLine("Informe o valor da diária:");
decimal valorDiaria = decimal.Parse(Console.ReadLine() ?? "0");
Suite suite = new Suite
{
    TipoSuite = tipoSuite,
    Capacidade = capacidade,
    ValorDiaria = valorDiaria
};

//Cadastro de hospedes
Console.WriteLine("Quantos hóspedes irão se hospedar?");
int numeroHospedes = int.Parse(Console.ReadLine() ?? "1");

var hospedes = new List<Pessoa>();
for (int i = 0; i < numeroHospedes; i++)
{
    Console.WriteLine($"Informe o nome do hóspede {i + 1}:");
    string nome = Console.ReadLine() ?? string.Empty;
    Console.WriteLine($"Informe o sobrenome do hóspede {i + 1}:");
    string sobrenome = Console.ReadLine() ?? string.Empty;

    hospedes.Add(new Pessoa { Nome = nome, Sobrenome = sobrenome });
}

Console.WriteLine("Informe o número de dias reservados:");
int diasReservados = int.Parse(Console.ReadLine());
var reserva = new Reserva
{
    Suite = suite,
    DiasReservados = diasReservados
};
reserva.CadastrarHospedes(hospedes);

decimal valorTotal = reserva.CalcularValorDiaria();
Console.WriteLine("Resumo da Reserva:");
Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()} ");
Console.WriteLine($"Tipo da suíte: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor total da reserva: R${valorTotal:F2}");


