using MediatR;
using MWS.Domain.Entities;

namespace MWS.Application.UseCases.Clientes.CreateCliente
{
    public sealed record CreateClienteRequest(string Cpf, string? Rg, DateTime? DataNascimento, string? Nome, string? RazaoSocial, string? Telefone, Endereco? Endereco) : IRequest<CreateClienteResponse>
    {
    }
}
