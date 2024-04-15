using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator;

public class BillValidator : AbstractValidator<Bill>
{
    public BillValidator()
    {
        RuleFor(b => b.SaleId).NotEmpty().WithMessage(ValidationMessages.BillHasToBeSaleToAdd);
    }
}
