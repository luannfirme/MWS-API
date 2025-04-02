using FluentValidation;

namespace MWS.Application.UseCases.Clientes.CreateCliente
{
    public sealed class CreateClienteValidator : AbstractValidator<CreateClienteRequest>
    {
        public CreateClienteValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().MaximumLength(50).WithMessage("Informe o nome do cliente corretamente");
            RuleFor(x => x.Cpf).MinimumLength(11).MaximumLength(14).When(x => string.IsNullOrEmpty(x.Cpf)).WithMessage("Informe um CPF/CNPJ válido");
            RuleFor(x => x.RazaoSocial).MinimumLength(3).MaximumLength(100).When(x => string.IsNullOrEmpty(x.Cpf) && x.Cpf.Length > 11).WithMessage("Informe a razão social do CNPJ informado");
            RuleFor(x => x.DataNascimento).NotEqual(DateTime.MinValue).When(x => x.DataNascimento != null).WithMessage("Informe uma data de nascimento válida");
        }
    }
}
