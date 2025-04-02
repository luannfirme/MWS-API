namespace MWS.Domain.Entities
{
    public sealed class Funcionario : BaseEntity
    {
        public required string Cpf { get; set; }
        public required string Nome { get; set; }
        public string? Telefone { get; set; }
        public int CargaHoraria { get; set; }
        public double Salario { get; set; }
        public Guid? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public Guid CargoId { get; set; }
        public FuncionarioCargo Cargo { get; set; }
        public List<OrdemServicoExecutado> Servicos { get; set; }
    }
}
