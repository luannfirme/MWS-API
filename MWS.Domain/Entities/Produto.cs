namespace MWS.Domain.Entities
{
    public sealed class Produto : BaseEntity
    {
        public required string Codigo { get; set; }
        public string? Descricao { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoCompra { get; set; }
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<OrdemServico> Servicos { get; set; }
    }
}
