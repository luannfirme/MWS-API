using MediatR;

namespace MWS.Application.UseCases.Clientes.GetByCpfCliente
{
    public sealed record GetByCpfClienteRequest(string Cpf) : IRequest<GetByCpfClienteResponse>
    {
    }
}
