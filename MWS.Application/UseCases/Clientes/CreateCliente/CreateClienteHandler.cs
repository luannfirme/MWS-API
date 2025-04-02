using AutoMapper;
using FluentValidation;
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
        private readonly IValidator<CreateClienteRequest> _validator;

        public CreateClienteHandler(IUnitOfWork unitOfWork, IClienteRepository clienteRepository, IMapper mapper, IValidator<CreateClienteRequest> validator)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
            _validator = validator;
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
