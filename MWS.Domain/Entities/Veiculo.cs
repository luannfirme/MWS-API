namespace MWS.Domain.Entities
{
    public sealed class Veiculo : BaseEntity
    {
        public string Placa { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public string Cor { get; set; }
        public Guid VeiculoModeloId { get; set; }
        public VeiculoModelo Modelo { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<OrdemServico> Servicos { get; set; }
    }
}
