using FluentValidation;

namespace Application.Features.Camera.Create
{
    public class CreaCameraCommandValidator : AbstractValidator<CreaCameraCommand>
    {
        public CreaCameraCommandValidator()
        {
            RuleFor(c => c.IsBagno).NotEmpty();
            RuleFor(c => c.IsMatrimoniale).NotEmpty();
            RuleFor(c => c.LettoSingola).NotEmpty();
            RuleFor(c => c.Metratura).NotEmpty().GreaterThan(0);
        }
    }
}
