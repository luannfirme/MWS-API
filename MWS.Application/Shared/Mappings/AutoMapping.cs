using AutoMapper;
using MWS.Application.UseCases.Clientes.CreateCliente;
using MWS.Application.UseCases.Clientes.DeleteCliente;
using MWS.Application.UseCases.Clientes.GetAllCliente;
using MWS.Application.UseCases.Clientes.UpdateCliente;
using MWS.Domain.Entities;

namespace MWS.Application.Shared.Mappings
{
    public sealed class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreateClienteRequest, Cliente>();
            CreateMap<Cliente, CreateClienteResponse>();
            CreateMap<Cliente, GetAllClienteResponse>();
            CreateMap<Cliente, UpdateClienteResponse>();
            CreateMap<Cliente, DeleteClienteResponse>();
        }
    }
}
