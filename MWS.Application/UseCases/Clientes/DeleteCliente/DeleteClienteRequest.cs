using MediatR;

namespace MWS.Application.UseCases.Clientes.DeleteCliente
{
    public sealed record DeleteClienteRequest(Guid Id) : IRequest<DeleteClienteResponse>
    {
    }
}
