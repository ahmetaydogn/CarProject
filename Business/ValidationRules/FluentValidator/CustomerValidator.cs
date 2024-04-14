using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(c => c.CustomerName).NotEmpty().WithMessage(ValidationMessages.CustomerNameEmpty);
        RuleFor(c => c.CustomerName).Length(2, 50).WithMessage(ValidationMessages.CustomerNameLength);
        RuleFor(c => c.CustomerSurname).NotEmpty().WithMessage(ValidationMessages.CustomerSurnameEmpty);
        RuleFor(c => c.CustomerSurname).Length(2, 50).WithMessage(ValidationMessages.CustomerSurnameLength);

        RuleFor(c => c.CustomerPhone).NotEmpty().WithMessage(ValidationMessages.CustomerPhone);
        RuleFor(c => c.CustomerTaxNo).Must(CreatedByTenLetter).WithMessage(ValidationMessages.CustomerTaxNo);
    }

    private bool CreatedByTenLetter(string arg)
    {
        return arg.Length == 10 ? true : false;
    }
}
