namespace MWS.Domain.Entities
{
    public sealed class OrdemServico : BaseEntity
    {
        public string Codigo { get; set; }
        public string Observacao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public double PrecoInicial { get; set; }
        public double PrecoFinal { get; set; }
        public Guid VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
        public List<Produto> Produtos { get; set; }
        public List<OrdemServicoExecutado> Servicos { get; set; }

    }
}
