namespace MWS.Domain.Entities
{
    public sealed class Servico : BaseEntity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public List<OrdemServicoExecutado> Servicos { get; set; }
    }
}
