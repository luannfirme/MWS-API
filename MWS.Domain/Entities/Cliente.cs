﻿namespace MWS.Domain.Entities
{
    public sealed class Cliente : BaseEntity
    {
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        public DateTime? DataNascimento { get; set; }
        public required string Nome { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Telefone { get; set; }
        public Guid? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public List<Veiculo>? Veiculos { get; set; }
    }
}
