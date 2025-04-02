using AutoMapper;
using MWS.Domain.Entities;

namespace MWS.Application.UseCases.Clientes.CreateCliente
{
    public sealed class CreateClienteMapper : Profile
    {
        public CreateClienteMapper()
        {
            CreateMap<CreateClienteRequest, Cliente>();
            CreateMap<Cliente, CreateClienteResponse>();
        }
    }
}
