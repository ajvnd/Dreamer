using Dreamer.Application.Commands.SampleCommands;
using FluentValidation;

namespace Dreamer.Application.Validators.SampleValidators;

public class SampleAddValidator : AbstractValidator<SampleAddCommand>
{
    public SampleAddValidator()
    {
        RuleFor(c => c.Lorem).NotEmpty().NotNull();
    }
}