using AutoMapper;
using MediatR;
using MWS.Domain.Interfaces;

namespace MWS.Application.UseCases.Clientes.GetAllCliente
{
    public sealed class GetAllClienteHandler : IRequestHandler<GetAllClienteRequest, List<GetAllClienteResponse>>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public GetAllClienteHandler(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllClienteResponse>> Handle(GetAllClienteRequest request, CancellationToken cancellationToken)
        {
            var clientes = await _clienteRepository.GetAll(cancellationToken);

            return _mapper.Map<List<GetAllClienteResponse>>(clientes);
        }
    }
}
