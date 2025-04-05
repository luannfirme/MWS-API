using MWS.Domain.Entities;

namespace MWS.Application.UseCases.Clientes.GetAllCliente
{
    public sealed record GetAllClienteResponse
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Nome { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Telefone { get; set; }
        public Endereco? Endereco { get; set; }
        public List<Veiculo>? Veiculos { get; set; }
    }
}
