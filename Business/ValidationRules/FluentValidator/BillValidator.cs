using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator;

public class BillValidator : AbstractValidator<Bill>
{
    public BillValidator()
    {
        RuleFor(b => b.Price).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.BillPriceGreater);
    }
}
