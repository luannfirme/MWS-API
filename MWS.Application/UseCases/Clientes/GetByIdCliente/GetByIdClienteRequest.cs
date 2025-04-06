using MediatR;

namespace MWS.Application.UseCases.Clientes.GetByIdCliente
{
    public sealed record GetByIdClienteRequest(Guid Id) : IRequest<GetByIdClienteResponse>
    {
    }
}
