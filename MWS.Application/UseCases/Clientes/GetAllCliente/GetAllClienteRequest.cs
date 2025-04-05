using MediatR;

namespace MWS.Application.UseCases.Clientes.GetAllCliente
{
    public sealed record GetAllClienteRequest : IRequest<List<GetAllClienteResponse>>;
}
