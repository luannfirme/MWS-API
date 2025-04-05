using MediatR;

namespace MWS.Application.UseCases.Clientes.UpdateCliente
{
    public sealed record UpdateClienteRequest(Guid Id, string? Cpf, string? Rg, DateTime? DataNascimento, string Nome, string? RazaoSocial, string? Telefone, bool Ativo) : IRequest<UpdateClienteResponse>
    {
    }
}
