namespace MWS.Application.UseCases.Clientes.CreateCliente
{
    public sealed record CreateClienteResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
