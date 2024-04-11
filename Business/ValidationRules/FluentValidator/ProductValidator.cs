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

        RuleFor(p => p.VAT).Must(VATPercent).WithMessage(ValidationMessages.ProductVATPercent);

        RuleFor(p => Convert.ToInt32(p.Quantity)).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductQuantity);

        RuleFor(p => p.VATPrice).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.ProductVATPrice);
    }

    private bool VATPercent(byte arg)
    {
        return arg == 10 | arg == 20;
    }
}
