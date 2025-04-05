namespace MWS.Application.UseCases.Clientes.DeleteCliente
{
    public sealed record DeleteClienteResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
