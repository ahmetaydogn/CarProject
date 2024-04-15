using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator;

public class SubProductValidator : AbstractValidator<SubProduct>
{
    public SubProductValidator()
    {
        RuleFor(p => p.SubProductName).NotEmpty().WithMessage(ValidationMessages.ProductNameEmpty);
        RuleFor(p => p.SubProductName).Length(3, 50).WithMessage(ValidationMessages.ProductNameLength);

        RuleFor(p => p.MarketPrice).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductMarketPriceGreater);
        RuleFor(p => p.SellPrice).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductSellPriceGreater);

        RuleFor(p => p.VATPrice).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductVATPrice);
    }
}
