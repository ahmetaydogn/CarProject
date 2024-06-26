﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator;

public class SaleValidator : AbstractValidator<Sale>
{
    public SaleValidator()
    {
        RuleFor(s => new { s.ProductId, s.SubProductId }).Must(x => BothOfThemNull(x.ProductId, x.SubProductId)).WithMessage(ValidationMessages.SaleProductCantBeEmpty);
        RuleFor(s => s.CustomerId).NotEmpty().WithMessage(ValidationMessages.SaleCustomerCantBeEmpty);
        
        RuleFor(s => s.Quantity).NotEmpty().WithMessage(ValidationMessages.SaleQuantityCantBeEmpty);
        RuleFor(s => Convert.ToInt32(s.Quantity)).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.SaleQuantityGreaterThan);
        RuleFor(s => s.Price).GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.SalePriceGreaterThan);
        
        RuleFor(s => s.PaymentMethod).NotEmpty().WithMessage(ValidationMessages.SalePaymentMethodCantBeEmpty);

        RuleFor(s => s.BillNumber).NotEmpty().WithMessage(ValidationMessages.BillNumber);
    }

    private bool BothOfThemNull(int? productId, int? subProductId)
    {
        return !(productId == null || subProductId == 0) && (subProductId == null || subProductId == 0);
    }
}
