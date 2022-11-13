using Dreamer.Application.Models.SampleModel;
using FluentValidation;

namespace Dreamer.Application.Validators.SampleValidator;

public class SampleAddValidator : AbstractValidator<SampleAddModel>
{
    public SampleAddValidator()
    {
        RuleFor(c => c.Lorem).NotEmpty().NotNull();
    }
}