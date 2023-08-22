using Business.Models.Request.Functional;
using FluentValidation;

namespace Business.Utilities.Validation;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator()
    {
        RuleFor(x => x.name).NotEmpty().WithName("name").MinimumLength(5);
        RuleFor(x => x.email).NotEmpty().WithName("email").EmailAddress();
        RuleFor(x => x.phone).NotEmpty().WithName("phone").MaximumLength(10);
        RuleFor(x => x.Password).NotEmpty().WithName("password").MinimumLength(8);
    }
}