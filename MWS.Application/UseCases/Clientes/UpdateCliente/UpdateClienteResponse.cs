namespace MWS.Application.UseCases.Clientes.UpdateCliente
{
    public sealed record UpdateClienteResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
