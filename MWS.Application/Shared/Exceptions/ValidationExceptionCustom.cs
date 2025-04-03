using FluentValidation.Results;

namespace MWS.Application.Shared.Exceptions
{
    public sealed class ValidationExceptionCustom : Exception
    {
        public List<string> Errors { get; }

        public ValidationExceptionCustom(List<ValidationFailure> failures) : base("Erro de validação")
        {
            Errors = failures.Select(f => $"{f.PropertyName}: {f.ErrorMessage}").ToList();
        }
    }
}
