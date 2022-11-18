using Dreamer.Application.Features.Sample.Commands;
using FluentValidation;

namespace Dreamer.Application.Validators.SampleValidators;

public class SampleAddValidator : AbstractValidator<SampleAddCommand>
{
    public SampleAddValidator()
    {
        RuleFor(c => c.Lorem).NotEmpty().NotNull();
    }
}