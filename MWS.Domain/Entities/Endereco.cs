namespace MWS.Domain.Entities
{
    public sealed class Endereco : BaseEntity
    {
        public required string Rua { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }
        public required string Bairro { get; set; }
        public required string Cidade { get; set; }
        public required string Estado { get; set; }
    }
}
