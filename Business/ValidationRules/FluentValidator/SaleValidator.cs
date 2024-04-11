using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator;

public class SaleValidator : AbstractValidator<Sale>
{
    public SaleValidator()
    {
        RuleFor(s => s.CustomerId).NotEmpty().WithMessage("");
        RuleFor(s => s.ProductId).NotEmpty().WithMessage("");
        
        RuleFor(s => s.Quantity).NotEmpty().WithMessage("");
        RuleFor(s => Convert.ToInt32(s.Quantity)).GreaterThanOrEqualTo(1).WithMessage("");
        RuleFor(s => s.Price).GreaterThanOrEqualTo(1).WithMessage("");
        
        RuleFor(s => s.PaymentMethod).NotEmpty().WithMessage("");
        RuleFor(s => s.PaymentMethod).NotEmpty().WithMessage("");

        RuleFor(s => s.BillNumber).NotEmpty().WithMessage("");
    }
}
