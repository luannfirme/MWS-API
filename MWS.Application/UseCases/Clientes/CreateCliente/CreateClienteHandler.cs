using AutoMapper;
using MediatR;
using MWS.Domain.Entities;
using MWS.Domain.Interfaces;

namespace MWS.Application.UseCases.Clientes.CreateCliente
{
    public sealed class CreateClienteHandler : IRequestHandler<CreateClienteRequest, CreateClienteResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public CreateClienteHandler(IUnitOfWork unitOfWork, IClienteRepository clienteRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<CreateClienteResponse> Handle(CreateClienteRequest request, CancellationToken cancellationToken)
        {
            var cliente = _mapper.Map<Cliente>(request);

            _clienteRepository.Create(cliente);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateClienteResponse>(cliente);
        }
    }
}
