namespace MWS.Domain.Entities
{
    public sealed class VeiculoModelo : BaseEntity
    {
        public string Nome { get; set; }
        public Guid VeiculoMontadoraId { get; set; }
        public VeiculoMontadora Montadora { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
