using AutoMapper;
using MediatR;
using MWS.Domain.Interfaces;

namespace MWS.Application.UseCases.Clientes.GetByIdCliente
{
    public sealed class GetByIdClienteHandler : IRequestHandler<GetByIdClienteRequest, GetByIdClienteResponse>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public GetByIdClienteHandler(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdClienteResponse> Handle(GetByIdClienteRequest request, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.GetById(request.Id, cancellationToken);

            if (cliente == null)
                return default;

            return _mapper.Map<GetByIdClienteResponse>(cliente);
        }
    }
}
