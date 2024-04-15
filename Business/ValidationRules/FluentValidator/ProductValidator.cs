using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator;

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.ProductName).NotEmpty().WithMessage(ValidationMessages.ProductNameEmpty);
        RuleFor(p => p.ProductName).Length(3, 50).WithMessage(ValidationMessages.ProductNameLength);
        
        RuleFor(p => p.MarketPrice).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductMarketPriceGreater);
        RuleFor(p => p.SellPrice).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductSellPriceGreater);

        RuleFor(p => p.VATPrice).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductVATPrice);
    }
}
