namespace MWS.Domain.Entities
{
    public sealed class VeiculoMontadora : BaseEntity
    {
        public string Nome { get; set; }
        public List<VeiculoModelo> Modelos { get; set; }
    }
}
