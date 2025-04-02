namespace MWS.Domain.Entities
{
    public sealed class Fornecedor : BaseEntity
    {
        public required string Cnpj { get; set; }
        public required string RazaoSocial { get; set; }
        public required string NomeFantasia { get; set; }
        public string? Contato { get; set; }
        public string? Email { get; set; }
        public Guid? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
