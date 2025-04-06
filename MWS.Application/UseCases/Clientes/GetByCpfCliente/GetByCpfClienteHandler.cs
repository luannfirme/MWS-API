using AutoMapper;
using MediatR;
using MWS.Domain.Interfaces;

namespace MWS.Application.UseCases.Clientes.GetByCpfCliente
{
    public sealed class GetByCpfClienteHandler : IRequestHandler<GetByCpfClienteRequest, GetByCpfClienteResponse>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public GetByCpfClienteHandler(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<GetByCpfClienteResponse> Handle(GetByCpfClienteRequest request, CancellationToken cancellationToken)
        {
            var cliente = _clienteRepository.Search(x => x.Cpf == request.Cpf, cancellationToken).Result.FirstOrDefault();

            if (cliente == null)
                return default;

            return _mapper.Map<GetByCpfClienteResponse>(cliente);
        }
    }
}
