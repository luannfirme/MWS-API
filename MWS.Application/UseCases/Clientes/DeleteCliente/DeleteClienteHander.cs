using AutoMapper;
using MediatR;
using MWS.Domain.Interfaces;

namespace MWS.Application.UseCases.Clientes.DeleteCliente
{
    public sealed class DeleteClienteHander : IRequestHandler<DeleteClienteRequest, DeleteClienteResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public DeleteClienteHander(IUnitOfWork unitOfWork, IClienteRepository clienteRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<DeleteClienteResponse> Handle(DeleteClienteRequest request, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.GetById(request.Id, cancellationToken);

            if (cliente == null)
                return default;

            _clienteRepository.Delete(cliente);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteClienteResponse>(cliente);
        }
    }
}
