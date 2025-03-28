namespace MWS.Domain.Entities
{
    public sealed class OrdemServicoExecutado : BaseEntity
    {
        public Guid OrdemServicoId { get; set; }
        public OrdemServico OrdemServico { get; set; }
        public Guid ServicoId { get; set; }
        public Servico Servico { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

    }
}
