using AutoMapper;
using MediatR;
using MWS.Domain.Interfaces;

namespace MWS.Application.UseCases.Clientes.UpdateCliente
{
    public sealed class UpdateClienteHandler : IRequestHandler<UpdateClienteRequest, UpdateClienteResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public UpdateClienteHandler(IUnitOfWork unitOfWork, IClienteRepository clienteRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateClienteResponse> Handle(UpdateClienteRequest request, CancellationToken cancellationToken)
        {
            var cliente = await _clienteRepository.GetById(request.Id, cancellationToken);

            if (cliente == null)
                return default;

            cliente.Nome = request.Nome;
            cliente.Ativo = request.Ativo;
            cliente.Rg = !string.IsNullOrEmpty(request.Rg) ? request.Rg : cliente.Rg;
            cliente.Cpf = !string.IsNullOrEmpty(request.Cpf) ? request.Cpf : cliente.Cpf;
            cliente.Telefone = !string.IsNullOrEmpty(request.Telefone) ? request.Telefone : cliente.Telefone;
            cliente.DataNascimento = request.DataNascimento != null ? request.DataNascimento : cliente.DataNascimento;

            _clienteRepository.Update(cliente);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateClienteResponse>(cliente);
        }
    }
}
